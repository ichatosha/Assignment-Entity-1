using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Entity_1
{
    internal class Instructor
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRateBouns { get; set; }

        public int Dept_ID { get; set; } // Foreign key to Department
        public Department Department { get; set; }

        public ICollection<Course_Inst> Course_Insts { get; set; }
    }
}
