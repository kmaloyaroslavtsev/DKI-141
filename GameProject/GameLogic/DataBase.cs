using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace GameLogic
{
    public static class DataBase
    {
        public static List<Card> Cards { get; set; }

        static DataBase()
        {
            Cards = new List<Card>();
            Card a1 = new AttackerCard()
            {
                Name = "kjgccc",
                PowerOfAttack = 13,
                Cost = 12,
                Health = 3

            };
            Card a2 = new AttackerCard()
            {
                Name = "kc",
                PowerOfAttack = 23,
                Cost = 12,
                Health = 2

            };
            Card a3 = new AttackerCard()
            {
                Name = "ccc",
                PowerOfAttack = 10,
                Cost = 12,
                Health = 1

            };
            Cards.Add(a1);
            Cards.Add(a2);
            Cards.Add(a3);
        }
        static Random rnd = new Random(DateTime.Now.Millisecond);
        public static Card GetRandomCard()
        {
            
            int r= rnd.Next(0, Cards.Count - 1);
                
            return Cards[r];
        }
        }
    }
