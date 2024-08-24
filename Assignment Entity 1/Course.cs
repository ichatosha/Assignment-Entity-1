using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Entity_1
{
    internal class Course
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public int Top_ID { get; set; } // Foreign key to Topic
        public Topic Topic { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }
}
