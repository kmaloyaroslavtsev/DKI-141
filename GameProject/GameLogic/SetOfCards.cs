using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class SetOfCards
    {
        public List<Card> Cards { get; set; }

        public Card GetNextCard()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            var randomValue=rnd.Next(0, Cards.Count-1);
            var neededCard = Cards[randomValue];
            Cards.RemoveAt(randomValue);
            return neededCard;
        }

        public SetOfCards()
        {
            Cards = new List<Card>();
        }
    }
}