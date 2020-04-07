﻿namespace Example3_FightingObjects
{
    public class BadGuy
    {
        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Name;
        public double Money;

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public BadGuy(string name, double money)
        {
            Show.CreationMessage(name, money);
            this.Name = name;
            this.Money = money;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Steal(GoodGuy goodGuy, double amount)// here's where the info enters
         {
            this.Money += amount; // money added
            goodGuy.Money -= amount; // money subtracted
            Show.StealMessage(this, goodGuy, amount); // parameters locked in for show class method
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Steal(BadGuy otherBadGuy, double amount)
        {
            this.Money += amount;
            otherBadGuy.Money -= amount;
            Show.StealMessage(this, otherBadGuy, amount);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
