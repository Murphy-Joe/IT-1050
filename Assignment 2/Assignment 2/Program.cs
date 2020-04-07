using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            Person P2 = new Person();

            P1.GetAnswers();
            Console.WriteLine();
            P2.GetAnswers();

            Console.WriteLine();
            P1.PrintNameAndAge();
            P2.PrintNameAndAge();
            P1.Spouse.PrintNameAndAge();
            P2.Spouse.PrintNameAndAge();
            Console.WriteLine();
            Console.WriteLine("Average Age of All " + Person.Count + " People: " + Person.AvgAge());

        }
    }
}
