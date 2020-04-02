using System;
namespace assignment4
{
    public class Concession
    {
        public string item;
        public double price;
        public int numberOfItems;
        public static double totalCost;

        public Concession()
        {

        }

        public Concession(string itemName, double priceAmt)
        {
            this.item = itemName;
            this.price = priceAmt;
        }


        public static void Header()
        {
            Ticket.Bar();
            Console.WriteLine(Ticket.Formatted("Enter the number of concessions would"));
            Console.WriteLine(Ticket.Formatted("you like to add please."));
            Ticket.Bar();
        }
        public void ConcesionChoice()
        { 
            Console.Write(this.item + ": ");
            this.numberOfItems = int.Parse(Console.ReadLine());
            totalCost += (this.numberOfItems * this.price);
        }

    }
}
