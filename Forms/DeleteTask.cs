using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.EF;

namespace TaskManagement.Forms
{
    public partial class DeleteTask : Form
    {
        public DeleteTask()
        {
            InitializeComponent();

            using (var db = new TaskManagementContext())
            {
                cbTaskID.DataSource = db.TaskSet.Select(s => s.ID).ToList();
            }
        }

        private bool ValidateComboBox()
        {
            return cbTaskID.Text != "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateComboBox())
            {
                var confirmResult = MessageBox.Show("Do you really want to delete this item?",
                                     "Deletion confirmation",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (var db = new TaskManagementContext())
                    {
                        int selectedTaskID = int.Parse(cbTaskID.Text);
                        List<EF.Models.Employee> assginedEmployees = db.EmployeeSet.Where(w => w.TaskID == selectedTaskID).ToList();
                        foreach (EF.Models.Employee employee in assginedEmployees)
                        {
                            employee.TaskID = null;
                            employee.Task = null;
                            db.EmployeeSet.AddOrUpdate(employee);
                        }
                        db.SaveChanges();

                        db.TaskSet.Remove(db.TaskSet.Where(w => w.ID == selectedTaskID).First());
                        db.SaveChanges();
                        Close();
                    }
                }
            }
            else
            {

            }
        }
    }
}
