using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Entity_1
{
    internal class Department
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }


    }
}
