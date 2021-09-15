using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCards
{
    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            for (int value = 2; value < 5; ++value)
            {
                cards.Add(new Card(value, "heart"));
                cards.Add(new Card(value, "diamond"));
                cards.Add(new Card(value, "spade"));
                cards.Add(new Card(value, "club"));
            }
        }
        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; ++i)
            {
                Random random = new Random();
                int nr = random.Next(cards.Count);
                // swap each card with random card
                Card card = cards[i];
                cards[i] = cards[nr];
                cards[nr] = card;
            }
        }

        public override string ToString()
        {
            String text = "";
            foreach (Card card in cards)
            {
                text += card.ToString() + Environment.NewLine;
            }
            return text;
        }
        public Card DrawCard()
        {
            int lastIndex = cards.Count - 1;
            Card card = cards[lastIndex];
            cards.RemoveAt(lastIndex);
            return card;
        }
    }
}
