using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFinalVP
{
    public class Course
    {
        internal ICollection<StudentCourse> StudentCourses;

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        // Add other properties as needed
    }
}
