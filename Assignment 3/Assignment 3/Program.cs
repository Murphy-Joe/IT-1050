using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "Neeboy", "English");
            Instructor mike = new Instructor("Mike", "Chael", "Math");

            Student jane = new Student("Jane", "White", john);
            Student joe = new Student("Joe", "Murphy", john);
            Student melissa = new Student("Melissa", "Green", mike);
            Student matt = new Student("Matt", "Black", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            jane.Print();
            joe.Print();
            melissa.Print();
            matt.Print();

        }
    }
}
