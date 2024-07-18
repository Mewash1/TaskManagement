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
using TaskManagement.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            using (var db = new TaskManagementContext())
            {
                cbEmployees.DataSource = db.EmployeeSet.Select(s => new ComboboxItem()
                {
                    Value = s.ID,
                    Text = s.Name,
                }).ToList();
            }
        }

        private void btnEmployeeView_Click(object sender, EventArgs e)
        {
            Employee chosenUser;
            int chosenUserID = (cbEmployees.SelectedItem as ComboboxItem).Value;

            using (var db = new TaskManagementContext())
            {
                chosenUser = db.EmployeeSet
                    .Where(w => w.ID == chosenUserID)
                    .FirstOrDefault();
            }

            using (EmployeeView employeeView = new EmployeeView(chosenUser))
            {
                employeeView.ShowDialog();
            }
        }

        private class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
