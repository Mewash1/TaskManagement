using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.EF;
using TaskManagement.Models;

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
                db.UserSet.RemoveRange(db.UserSet.Select(s => s));
                db.UserTypeSet.RemoveRange(db.UserTypeSet.Select(s => s));
                db.TaskSet.RemoveRange(db.TaskSet.Select(s => s));

                UserType employee = new Models.UserType { ID = 1, Name = "Employee" };
                UserType manager = new Models.UserType { ID = 2, Name = "Manager" };

                db.UserTypeSet.Add(employee);
                db.UserTypeSet.Add(manager);

                db.UserSet.Add(new Models.User { Name = "Employee_1", UserType = employee });
                db.UserSet.Add(new Models.User { Name = "Employee_2", UserType = employee });
                db.UserSet.Add(new Models.User { Name = "Manager", UserType = manager });

                db.TaskSet.Add(new Models.Task { Priority = 1, Title = "Employee 1 task", Description = "bla bla bla",  });
                db.TaskSet.Add(new Models.Task { Priority = 2, Title = "Code optimization", Description = "bla bla bla" });

                db.SaveChanges();
            }
        }
    }
}
