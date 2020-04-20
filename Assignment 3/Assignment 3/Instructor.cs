using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Instructor
    {
        private string firstName;
        private string lastName;
        private string courseName;

        public Instructor(string teacherFirstName, string teacherLastName, string courseTitle)
        {
            this.firstName = teacherFirstName;
            this.lastName = teacherLastName;
            this.courseName = courseTitle;
        }

        public void SetStudentGrade(Student pickStudent, int giveGrade)
        {
            pickStudent.SetGrade(giveGrade);
        }

        public string Print()
        {
            return firstName + " " + lastName.PadRight(10) + " " + courseName;
        }
    }
}

