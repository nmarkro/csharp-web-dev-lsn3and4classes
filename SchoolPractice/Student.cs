using System;
using System.Runtime.InteropServices;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double totalQualityScore = Gpa * NumberOfCredits;
            double courseQualityScore = grade * courseCredits;
            totalQualityScore += courseQualityScore;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (NumberOfCredits >= 90)
            {
                return "Senior";
            } else if (NumberOfCredits >= 60)
            {
                return "Junior";
            } else if (NumberOfCredits >= 30)
            {
                return "Sophomore";
            } else if (NumberOfCredits >= 0)
            {
                return "Freshman";
            }
            return "grade level tbd";
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
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

            return (obj as Student).StudentId == this.StudentId;
        }
    }
}
