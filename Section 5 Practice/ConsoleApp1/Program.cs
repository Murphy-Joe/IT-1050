using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int x = 0; x < 3; x++)
            {
                people[x] = new Person();
                people[x].SetFirstName();
                people[x].SetLastName();
            }

            foreach (Person callItAnthing in people)
            {
                callItAnthing.FullName();
            }

            
        }

    }
}
