using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCards
{
    class UserInterface
    {
        private Deck deck = new Deck();

        public void Run()
        {
            Console.WriteLine("kortlekens innehåll");
            Console.WriteLine(deck.ToString());

            Console.WriteLine("blanda");
            deck.Shuffle();

            Console.WriteLine("kortlekens innehåll");
            Console.WriteLine(deck.ToString());

            Card myCard = deck.DrawCard();
            Console.WriteLine("mitt kort");
            Console.WriteLine(myCard.ToString());

            Console.WriteLine("kortlekens innehåll");
            Console.WriteLine(deck.ToString());
        }
    }
}
