using System.Dynamic;

namespace GameLogic
{
    public class Engine
    {
        public SetOfCards UpperPlayer { get; set; }
        
        public SetOfCards LowerPlayer { get; set; }

        public void StartGame()
        {
            UpperPlayer = new SetOfCards();
            LowerPlayer = new SetOfCards();
            for (int i = 0; i < 30; i++)
            {
                UpperPlayer.Cards.Add(DataBase.GetRandomCard());
                LowerPlayer.Cards.Add(DataBase.GetRandomCard());
            }            
        }

    }
}