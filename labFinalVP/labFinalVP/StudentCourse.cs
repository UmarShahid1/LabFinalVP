using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labFinalVP
{

    // StudentCourse.cs
    public class StudentCourse
    {
        internal object Course;

        public int StudentCourseId { get; set; }

        public int StudentId { get; set; }

        private Student student;

        public virtual Student GetStudent()
        {
            return student;
        }

        public virtual void SetStudent(Student value)
        {
            student = value;
        }

        public int CourseId { get; set; }
        public object Student { get; internal set; }

        private Course course;

        public virtual Course GetCourse()
        {
            return course;
        }

        public virtual void SetCourse(Course value)
        {
            course = value;
        }
    }
}





