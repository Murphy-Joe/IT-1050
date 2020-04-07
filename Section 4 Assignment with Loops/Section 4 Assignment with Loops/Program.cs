using System;

namespace assignment4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ticket.DiscountsAndPromotions();
            Ticket.MatineeOrEvening();

            Ticket[] types = new Ticket[3];

            types[0] = new Ticket("Children under the age of 18: ", 3.99, 6.99);
            types[1] = new Ticket("Adults 18-65 year old: ", 5.99, 10.99);
            types[2] = new Ticket("Adults over 65 years old: ", 4.50, 8.50);

            Ticket.Header();
            foreach (Ticket type in types)
            {
                type.NumberOfTickets();
            }


            //Concession[] items = new Concession[5];
            //items[0] = new Concession("Small Sodas", 3.50);
            //items[1] = new Concession("Large Sodas", 5.99);
            //items[2] = new Concession("Hot Dogs", 3.99);
            //items[3] = new Concession("Popcorn", 4.50);
            //items[4] = new Concession("Candy", 1.99);
            //foreach (Concession item in items)
            //{
            //    item.ConcesionChoice();
            //} 

            // The previous would have correctly created an array and assigned
            // the ConcessionChoice() method to each item
            //  *BUT* the if statements would have all then needed updated to 
            // their item [number] addresses rather than their object name,  
            // making the code much less readable

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
