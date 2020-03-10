namespace Example3_FightingObjects
{
    public static class Show
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        public static void HorizontalDivider()
        {
            System.Console.WriteLine(" +========================================================+");
        }

        public static void CaptureMessage(GoodGuy goodGuy, BadGuy badGuy, double amount)
        {
            Show.Formatted(goodGuy.Name + " captured " + badGuy.Name + " and got " + amount);
            Show.Money(goodGuy);
            Show.Money(badGuy);
        }

        public static void GiveMessage(GoodGuy giver, GoodGuy receiver, double amount)
        {
            Show.Formatted(giver.Name + " gave " + amount + " to " + receiver.Name);
            Show.Money(giver);
            Show.Money(receiver);
        }

        public static void StealMessage(BadGuy badGuy, GoodGuy goodGuy, double amount) // parameters came from BadGuy class steal method
        {
            Show.Formatted(badGuy.Name + " stole " + amount + " from " + goodGuy.Name); // formatted writeLine
            Show.Money(badGuy); // uses the submethod to automatically grab badGuy.name and badGuy.money
            // to pass them as the string and double parameters in the main Money method. 
            Show.Money(goodGuy);
        }

        public static void StealMessage(BadGuy badGuy, BadGuy otherBadGuy, double amount)
        {
            Show.Formatted(badGuy.Name + " stole " + amount + " from " + otherBadGuy.Name);
            Show.Money(badGuy);
            Show.Money(otherBadGuy);
        }

        public static void CreationMessage(string name, double amount)
        {
            Show.Formatted(name + " has been created and has " + amount);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////

        private static void Money(string name, double amount) // could also run money method by directly feeding it info
        {
            Show.Formatted(name + " now has a total of " + amount);
        }

        private static void Money(GoodGuy goodGuy)
        {
            Show.Money(goodGuy.Name, goodGuy.Money); // run money method w/ these parameters that auto loaded object info
        }

        private static void Money(BadGuy badGuy) // multiple constuctor options
        {
            Show.Money(badGuy.Name, badGuy.Money);
        }


        private static void Formatted(string output)
        {
            output += ".";
            System.Console.WriteLine(" | " + output.PadRight(54) + " | ");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
    }
}
