using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.EF.Models
{
    public class Manager : Employee
    {
        public List<Employee> Employees { get; set; }
    }
}
