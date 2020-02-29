using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;


        public Person()
        {

        }
        public Person(int theirAge, string theirFirstName, string theirLastName, Person theirSpouse)
        {
            Age = theirAge;
            FirstName = theirFirstName;
            LastName = theirLastName;
            Spouse = theirSpouse;
        }

        public static int Count;
        public static double SumOfAllAges;
        
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine(this.GetFullName() + " is " + Age + " years old.");
        }

        public void GetAnswers()
        {
            Console.Write("Your First Name:         ");
            this.FirstName = Console.ReadLine();

            Console.Write("Your Last Name:          ");
            this.LastName = Console.ReadLine();

            Console.Write("Your Age:                ");
            this.Age = int.Parse(Console.ReadLine());

            Console.Write("Your Spouse' First Name: ");
            this.Spouse = new Person();
            this.Spouse.FirstName = Console.ReadLine();
            this.Spouse.LastName = this.LastName;
            this.Spouse.Spouse = this;

            Console.Write("Your Spouse' age:        ");
            this.Spouse.Age = int.Parse(Console.ReadLine());

            Person.Count += 2;
            Person.SumOfAllAges += this.Age + this.Spouse.Age;

        }
        public static double AvgAge()
        {
            return Person.SumOfAllAges / Person.Count;
        }
    }
}
