using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.EF;
using TaskManagement.EF.Models;

namespace TaskManagement.Forms
{
    public partial class AddTask : Form
    {
        private Employee CurrentEmployee;
        public AddTask(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;
        }

        private bool ValidateTextbox()
        {
            return int.TryParse(txtPriority.Text, out _);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateTextbox())
            {
                using (var db = new TaskManagementContext())
                {
                    db.TaskSet.Add(new EF.Models.Task() { Title = txtTitle.Text, Description = txtDescription.Text, Priority = int.Parse(txtPriority.Text), AssignedEmployees = new List<Employee>() {CurrentEmployee} });
                    db.SaveChanges();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Error: invalid data");
            }
            
        }
    }
}
