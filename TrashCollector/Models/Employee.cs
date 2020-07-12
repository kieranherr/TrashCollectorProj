using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public bool pickup { get; set;  }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string ZipCode { get; set; }
    }
}
