using System;
using System.Collections.Generic;

namespace GameProject
{
    public class Interface
    {
        private List<string> _lowerPlayerCardsInHand;
        private List<string> _lowerPlayerCardsOnBoard;
        private List<string> _upperPlayerCardsInHand;
        private List<string> _upperPlayerCardsOnBoard;
        private int _currentIndex;

        private Player _currentPlayer;
        private GameZone _currentZone;

        public Interface()
        {
            _currentPlayer = Player.UpperPlayer;
            _currentZone = GameZone.CardsOnTable;
            _currentIndex = 0;

            var Engine = new GameLogic.Engine();
            Engine.StartGame();

            _upperPlayerCardsOnBoard = new List<string> {"card 1", "card 2", "card 3"};
            _upperPlayerCardsInHand = new List<string>();
            foreach (var setOfCard in Engine.UpperPlayer.Cards)
            {
                _upperPlayerCardsInHand.Add(setOfCard.ToString());
            }
            _lowerPlayerCardsInHand = new List<string>();
            foreach (var setOfCard in Engine.LowerPlayer.Cards)
            {
                _lowerPlayerCardsInHand.Add(setOfCard.ToString());
            }
            _lowerPlayerCardsOnBoard = new List<string> { "card 1", "card 2", "card 3" };

            Print(_currentPlayer, _currentZone, _currentIndex);
        }

        private void PrintActiveArea(List<string> cardsInHand, int indexOfSelectedPosition)
        {
            Console.WriteLine();
            Console.WriteLine("#######################################");
            for (int i = 0; i < cardsInHand.Count; i++)
            {
                if (i == indexOfSelectedPosition)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(cardsInHand[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(cardsInHand[i]);
                }
            }
            Console.WriteLine("#######################################");
            Console.WriteLine();
        }

        private void PrintUpperPlayer(int indexOfSelectedPosition)
        {
            Console.WriteLine("### Герой 1    Здоровье: 30     Броня:0 ###");
            for (int i = 0; i < _upperPlayerCardsOnBoard.Count; i++)
            {
                if (i == indexOfSelectedPosition)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(_upperPlayerCardsOnBoard[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(_upperPlayerCardsOnBoard[i]);
                }
            }
        }

        private void PrintLowerPlayer(int indexOfSelectedPosition)
        {
            for (int i = 0; i < _lowerPlayerCardsOnBoard.Count; i++)
            {
                if (i == indexOfSelectedPosition)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(_lowerPlayerCardsOnBoard[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(_lowerPlayerCardsOnBoard[i]);
                }
            }
            Console.WriteLine("### Герой 2    Здоровье: 30     Броня:0 ###");
        }

        public void KeyHandler()
        {
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (_currentPlayer == Player.UpperPlayer && _currentZone == GameZone.CardsOnTable)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = GameZone.CardsInHands;
                            _currentIndex = _upperPlayerCardsInHand.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == Player.UpperPlayer && _currentZone == GameZone.CardsInHands)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = GameZone.CardsOnTable;
                            _currentIndex = _upperPlayerCardsOnBoard.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == Player.LowerPlayer && _currentZone == GameZone.CardsOnTable)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = GameZone.CardsInHands;
                            _currentIndex = _lowerPlayerCardsInHand.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == Player.LowerPlayer && _currentZone == GameZone.CardsInHands)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = GameZone.CardsOnTable;
                            _currentIndex = _lowerPlayerCardsOnBoard.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    Print(_currentPlayer, _currentZone, _currentIndex);
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (_currentPlayer == Player.UpperPlayer && _currentZone == GameZone.CardsOnTable)
                    {
                        if (_currentIndex == _upperPlayerCardsInHand.Count - 1)
                        {
                            _currentZone = GameZone.CardsInHands;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == Player.UpperPlayer && _currentZone == GameZone.CardsInHands)
                    {
                        if (_currentIndex == _upperPlayerCardsOnBoard.Count - 1)
                        {
                            _currentZone = GameZone.CardsOnTable;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == Player.LowerPlayer && _currentZone == GameZone.CardsOnTable)
                    {
                        if (_currentIndex == _lowerPlayerCardsInHand.Count - 1)
                        {
                            _currentZone = GameZone.CardsInHands;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == Player.LowerPlayer && _currentZone == GameZone.CardsInHands)
                    {
                        if (_currentIndex == _lowerPlayerCardsOnBoard.Count - 1)
                        {
                            _currentZone = GameZone.CardsOnTable;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    Print(_currentPlayer, _currentZone, _currentIndex);
                }
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    if (_currentPlayer == Player.UpperPlayer)
                    {
                        _currentPlayer = Player.LowerPlayer;
                        _currentZone = GameZone.CardsOnTable;
                        _currentIndex = 0;
                    }
                    else if (_currentPlayer == Player.LowerPlayer)
                    {
                        _currentPlayer = Player.UpperPlayer;
                        _currentZone = GameZone.CardsOnTable;
                        _currentIndex = 0;
                    }
                    Print(_currentPlayer, _currentZone, _currentIndex);
                }
            }
        }

        public void Print(Player playerNumber, GameZone typeOfAction, int index)
        {
            Console.Clear();
            if (playerNumber == Player.UpperPlayer)
            {
                if (typeOfAction == GameZone.CardsOnTable)
                {
                    PrintUpperPlayer(index);
                    PrintActiveArea(_upperPlayerCardsInHand, -1);
                }
                else
                {
                    PrintUpperPlayer(-1);
                    PrintActiveArea(_upperPlayerCardsInHand, index);
                }
                PrintLowerPlayer(-1);
            }
            else
            {
                PrintUpperPlayer(-1);
                if (typeOfAction == GameZone.CardsOnTable)
                {
                    PrintActiveArea(_lowerPlayerCardsInHand, -1);
                    PrintLowerPlayer(index);
                }
                else
                {
                    PrintActiveArea(_lowerPlayerCardsInHand, index);
                    PrintLowerPlayer(-1);
                }
            }
        }
    }
}