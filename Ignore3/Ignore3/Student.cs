using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int grade;
        private Instructor teacher;

        public Student(string pupilFirstName, string pupilLastName, Instructor teacherName)
        {
            this.firstName = pupilFirstName;
            this.lastName = pupilLastName;
            this.teacher = teacherName;
            this.grade = 0;
        }

        public void SetGrade(int giveGrade)
        {
            this.grade = giveGrade;
        }

        private string NameAndGrade()
        {
            return firstName + " " + lastName + ": " + grade;
        }
        public void Print()
        {
            Console.WriteLine(this.NameAndGrade().PadLeft(17) + "    Instructor: " + this.teacher.Print());
        }
    }
}
