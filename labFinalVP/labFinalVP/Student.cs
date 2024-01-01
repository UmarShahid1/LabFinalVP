using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFinalVP
{
    public class Student
    {
        internal ICollection<StudentCourse> StudentCourses;

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Add other properties as needed
    }
}
