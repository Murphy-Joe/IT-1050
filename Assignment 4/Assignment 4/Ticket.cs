using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    public class Ticket
    {
        public string description;
        public double matineePrice;
        public double eveningPrice;
        public int numberOfTickets;
        public static bool matinee;
        public static double totalCost;
        public static int totalNumberOfTickets;


        //constructor
        public Ticket(string description, double matineeCost, double eveningCost)
        {
            this.description = description;
            this.matineePrice = matineeCost;
            this.eveningPrice = eveningCost;
        }

        public static void Header()
        {
            Bar();
            Console.WriteLine(Formatted("Enter the number of people going."));
            Bar();
        }

        public static void DiscountsAndPromotions()
        {
            OtherBar();
            Console.WriteLine(OtherFormat("            *** DISCOUNTS AND PROMOTIONS ***"));
            Console.WriteLine(OtherFormat(""));
            Console.WriteLine(OtherFormat("Each purchase of a popcorn and a large soda"));
            Console.WriteLine(OtherFormat("grants a $2 discount on one movie ticket."));
            Console.WriteLine(OtherFormat(""));
            Console.WriteLine(OtherFormat("If 3 or more people purchase tickets to an evening show"));
            Console.WriteLine(OtherFormat("they get 1 free bag of popcorn. "));
            Console.WriteLine(OtherFormat(""));
            Console.WriteLine(OtherFormat("For each 3 candies you buy"));
            Console.WriteLine(OtherFormat("you can get a 4th candy for free."));
            OtherBar();
            Console.WriteLine();
        }

        public static void MatineeOrEvening()

        {
            Bar();
            Console.WriteLine(Formatted("For showtime selection, please type"));
            Console.WriteLine(Formatted("   1  --  for Matinee showing"));
            Console.WriteLine(Formatted("   2  --  for Evening showing"));
            Bar();
            Arrow();
            int timeSelection = int.Parse(Console.ReadLine());
            if (1 == timeSelection)
            {
                Console.WriteLine("You've selected Matinee");
                matinee = true;
            }
            else if (2 == timeSelection)
            {
                Console.WriteLine("You've selected Evening");
            }
            else
            {
                Console.WriteLine("You've entered an invalid option");
                Console.WriteLine();
                Ticket.MatineeOrEvening();
            }

        }

        public void NumberOfTickets()
        {
            Console.Write(this.description);
            this.numberOfTickets = int.Parse(Console.ReadLine());
            if (Ticket.matinee == true)
            {
                Ticket.totalCost += (this.numberOfTickets * this.matineePrice);
            }
            else
            {
                Ticket.totalCost += (this.numberOfTickets * this.eveningPrice);
            }
            Ticket.totalNumberOfTickets += this.numberOfTickets;
        }

        public static void Bar()
        {
            Console.WriteLine("+========================================+");

        }

        public static void OtherBar()
        {
            Console.WriteLine("   - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }

        public static string Formatted(string output)
        {
            return ("|  " + output.PadRight(38) + "|");
        }

        public static string OtherFormat(string output)
        {
            return ("  |  " + output.PadRight(59) + "|");
        }

        public static void Arrow()
        {
            Console.Write("---> ");
        }

        public static void Totals()
        {
            Console.WriteLine();
            Bar();
            Console.WriteLine(Formatted("Ticket Total: ".PadRight(25) + Ticket.totalCost));
            Console.WriteLine(Formatted("Concession Total: ".PadRight(25) +
                Concession.totalCost));
            Console.WriteLine(Formatted(""));
            Console.WriteLine(Formatted("Grand Total: ".PadRight(25) +
                (Ticket.totalCost + Concession.totalCost)));
            Bar();
        }
    }
}
