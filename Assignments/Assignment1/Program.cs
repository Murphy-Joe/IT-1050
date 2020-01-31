using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            int heightFeet;

            double heightInches;
            double totalHeightCM;

            bool isCitizen;
            bool canVote;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");
            middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name");
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.WriteLine("How many feet tall are you? (ignore the inches so 5'10 = 5)");
            heightFeet = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the inches remainder of your height? (IE 5'10 = 10)");
            heightInches = double.Parse(Console.ReadLine());

            totalHeightCM = heightFeet * 12 * 2.54 + heightInches * 2.54;

            Console.WriteLine("How old are you");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a United States citizen?");
            isCitizen = Console.ReadLine().ToUpper().StartsWith("Y");

            canVote = (age >= 18) && isCitizen;

            Console.WriteLine(fullName + " checks in at " + totalHeightCM + " centimeters.");
            Console.WriteLine(fullName + " can vote: " + canVote);

            Console.WriteLine("Hit any key to end");
            Console.ReadKey();

        }
    }
}
