using System.Collections.Generic;

namespace GameLogic
{
    public static class DataBase
    {
        public static List<Card> Cards { get; set; }

        static DataBase()
        {
            Cards = new List<Card>();
        }
    }
}