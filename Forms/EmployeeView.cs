using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.EF.Models;

namespace TaskManagement.Forms
{
    public partial class EmployeeView : Form
    {
        private Employee CurrentEmployee;
        private BindingSource source = new BindingSource();

        public EmployeeView(Employee currentEmployee)
        {
            InitializeComponent();
            CurrentEmployee = currentEmployee;

            UpdateDataSource();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateDataSource()
        {
            //source.DataSource = db.TaskSet
            //        .Where(w => w.AssignedEmployees.Select(s => s.ID).Contains(currentEmployee.ID)).ToList();
            using (var db = new EF.TaskManagementContext())
            {
                source.DataSource = db.TaskSet.ToList();
                source.ResetBindings(false);
            }
            
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            btnShowStats.Visible = CurrentEmployee.ManagerID == null;
            dgvTasks.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (AddTask addTask = new AddTask(CurrentEmployee))
            {
                addTask.ShowDialog();
            }
            
            UpdateDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (DeleteTask deleteTask = new DeleteTask())
            {
                deleteTask.ShowDialog();
            }

            UpdateDataSource();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //using (EditTask editTask = new EditTask(CurrentEmployee))
            //{
            //    editTask.ShowDialog();
            //}

            //UpdateDataSource();
        }
    }
}
