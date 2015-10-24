using System;
using System.Collections.Generic;

namespace GameLogic
{
    public class SetOfCards
    {
        private List<Card> Cards { get; set; }

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
            for (int i = 0; i < 30; i++)
            {
                Random rnd= new Random(DateTime.Now.Millisecond);
                var randomValue = rnd.Next(0, DataBase.Cards.Count-1);
                Cards.Add(DataBase.Cards[randomValue]);
            }
        }
    }
}