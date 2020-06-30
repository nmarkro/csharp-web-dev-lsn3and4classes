using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }

        public override string ToString()
        {
            return Topic + " (Teacher: " + Instructor.FirstName + " " + Instructor.LastName + ", Students: " + enrolledStudents + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            Course c = obj as Course;
            return c.Topic == this.Topic && c.Instructor == this.Instructor;
        }
    }
}
