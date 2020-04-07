using System;

namespace assignment4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ticket.DiscountsAndPromotions();
            Ticket.MatineeOrEvening();

            Ticket child = new Ticket("Children under the age of 18: ", 3.99, 6.99);
            Ticket adult = new Ticket("Adults 18-65 year old: ", 5.99, 10.99);
            Ticket senior = new Ticket("Adults over 65 years old: ", 4.50, 8.50);

            Ticket.Header();
            child.NumberOfTickets();
            senior.NumberOfTickets();
            adult.NumberOfTickets();


            Concession.Header();
            Concession smallSoda = new Concession("Small Sodas", 3.50);
            Concession largeSoda = new Concession("Large Sodas", 5.99);
            Concession hotDog = new Concession("Hot Dogs", 3.99);
            Concession popcorn = new Concession("Popcorn", 4.50);
            Concession candy = new Concession("Candy", 1.99);
            largeSoda.ConcesionChoice();
            smallSoda.ConcesionChoice();
            hotDog.ConcesionChoice();
            popcorn.ConcesionChoice();
            candy.ConcesionChoice();
            Console.WriteLine();


            if (popcorn.numberOfItems >= 1 && largeSoda.numberOfItems >= 1)
            {
                if (popcorn.numberOfItems >= largeSoda.numberOfItems)
                {
                    Ticket.totalCost -= 2 * largeSoda.numberOfItems;
                    Console.WriteLine("** You earned a discount of $" +
                        2 * largeSoda.numberOfItems + " for purchasing");
                    Console.WriteLine(largeSoda.numberOfItems + " " + largeSoda.item +
                        " and " + popcorn.numberOfItems + " buckets of " +
                        popcorn.item);
                }
                else
                {
                    Ticket.totalCost -= 2 * popcorn.numberOfItems;
                    Console.WriteLine("** You earned a discount of $" +
                        2 * popcorn.numberOfItems + " for purchasing");
                    Console.WriteLine(largeSoda.numberOfItems + " " + largeSoda.item +
                        " and " + popcorn.numberOfItems + " buckets of " +
                        popcorn.item);
                }
            }
            else
            {

            }

            if (Ticket.matinee == false && Ticket.totalNumberOfTickets >= 3)
            {
                popcorn.numberOfItems++;
                Concession.totalCost -= popcorn.price;
                Console.WriteLine("** You earned a free" + popcorn.item +
                    " for purchasing");
                Console.WriteLine(Ticket.totalNumberOfTickets +
                    " evening showings and a " + popcorn.item);
            }
            else
            {

            }

            if (candy.numberOfItems >= 3)
            {
                int freeCandies = candy.numberOfItems / 3;
                candy.numberOfItems += freeCandies;
                Concession.totalCost -= candy.price * (freeCandies);
                Console.WriteLine("** You earned " + freeCandies +
                    " free " + candy.item + " for purchasing");
                Console.WriteLine((candy.numberOfItems - freeCandies) +
                    " boxes of " + candy.item);
            }
            else
            {

            }

            Ticket.Totals();

        }
    }
}
