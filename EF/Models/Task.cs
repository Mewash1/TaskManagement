using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.EF.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public List<Employee> AssignedEmployees { get; set; }
    }
}
