using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        private string _firstName;
     
        public string GetFirstName()
        {
            return this._firstName;
        }

        public void SetFirstName()
        {
            Console.WriteLine("Type the first name: ");
            this._firstName = Console.ReadLine();
        }

        private string _lastName;

        public string GetLastName()
        {
            return this._lastName;
        }

        public void SetLastName()
        {
            Console.WriteLine("Type the last name: ");
            this._lastName = Console.ReadLine();
        }


        public string FullName()
        {
            Console.WriteLine(this._firstName + " " + this._lastName);
            return (this._firstName + " " + this._lastName);
        }
    }
}
