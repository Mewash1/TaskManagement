using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TaskManagement.EF.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public int? TaskID { get; set; }
        public Task Task { get; set; }
        public int? ManagerID { get; set; }
        public Manager Manager { get; set; }
    }
}
