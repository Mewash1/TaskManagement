using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.EF
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<Models.Employee> EmployeeSet { get; set; }
        public DbSet<Models.Manager> ManagerSet { get; set; }
        public DbSet<Models.Task> TaskSet { get; set; }
    }
}
