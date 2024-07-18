using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.EF;
using TaskManagement.EF.Models;

namespace TaskManagement
{
    internal static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        private static void InitializeData()
        {
            using (var db = new TaskManagementContext())
            {
                db.EmployeeSet.RemoveRange(db.EmployeeSet.Select(s => s));
                db.ManagerSet.RemoveRange(db.ManagerSet.Select(s => s));
                db.TaskSet.RemoveRange(db.TaskSet.Select(s => s));

                db.SaveChanges();

                Employee Employee_1 = new Employee { Name = "Employee_1" };
                Employee Employee_2 = new Employee { Name = "Employee_2" };
                Manager Manager = new Manager { Name = "Manager", Employees = new List<Employee>() {Employee_1, Employee_2} };

                db.EmployeeSet.Add(Employee_1);
                db.EmployeeSet.Add(Employee_2);
                db.ManagerSet.Add(Manager);

                db.SaveChanges();

                db.TaskSet.Add(new EF.Models.Task { Priority = 2, Title = "Employee 1 task", Description = "bla bla bla", AssignedEmployees = db.EmployeeSet.Where(w => w.Name == "Employee_1").ToList() });
                db.TaskSet.Add(new EF.Models.Task { Priority = 2, Title = "Employee 2 task", Description = "bla bla bla", AssignedEmployees = db.EmployeeSet.Where(w => w.Name == "Employee_2").ToList() });
                db.TaskSet.Add(new EF.Models.Task { Priority = 1, Title = "Manager task", Description = "bla bla bla", AssignedEmployees = db.EmployeeSet.Where(w => w.Name == "Manager").ToList() });
                db.TaskSet.Add(new EF.Models.Task { Priority = 1, Title = "Global task", Description = "bla bla bla", AssignedEmployees = db.EmployeeSet.ToList() });

                db.SaveChanges();

                var x = db.TaskSet.ToList();

                int z = 0;
            }
        }
    }
}
