using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.EF
{
    public class TaskManagementContext : DbContext
    {
        public DbSet<User> UserSet { get; set; }
        public DbSet<UserType> UserTypeSet { get; set; }
        public DbSet<Models.Task> TaskSet { get; set; }
    }
}
