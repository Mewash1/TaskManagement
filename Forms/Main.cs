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
using TaskManagement.Forms;

namespace TaskManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int employeeType = 1;
            int managerType = 2;
            using (var db = new TaskManagementContext())
            {
                cbEmployees.DataSource = db.UserSet.Where(w => w.UserType.ID == employeeType).Select(s => s.Name).ToList();
                cbManagers.DataSource = db.UserSet.Where(w => w.UserType.ID == managerType).Select(s => s.Name).ToList();
            }
        }

        private void btnEmployeeView_Click(object sender, EventArgs e)
        {
            Models.User chosenUser;
            string chosenUserName = cbEmployees.Text;

            using (var db = new TaskManagementContext())
            {
                chosenUser = db.UserSet.Where(w => w.Name == chosenUserName).FirstOrDefault();
            }

            using (EmployeeView employeeView = new EmployeeView(chosenUser))
            {
                employeeView.ShowDialog();
            }
        }

        private void btnManagerView_Click(object sender, EventArgs e)
        {

        }
    }
}
