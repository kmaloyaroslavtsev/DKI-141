using System;
using System.Collections.Generic;

namespace GameProject
{
    public class Interface
    {
        private List<string> _upperPlayerCardsOnBoard;
        private List<string> _lowerPlayerCardsOnBoard;
        private List<string> _upperPlayerCardsInHand;
        private List<string> _lowerPlayerCardsInHand;

        private int _currentPlayer;
        private int _currentZone;
        private int _currentIndex;

        public Interface()
        {
            _currentPlayer = 1;
            _currentZone = 1;
            _currentIndex = 0;

            _upperPlayerCardsOnBoard = new List<string>() { "card 1", "card 2", "card 3" };
            _upperPlayerCardsInHand = new List<string>() { "card 1", "card 2", "card 3" };
            _lowerPlayerCardsInHand = new List<string>() { "card 4", "card 5", "card 6" };
            _lowerPlayerCardsOnBoard = new List<string>() { "card 1", "card 2", "card 3" };

            Print(_currentPlayer, _currentZone, _currentIndex);
        }

        private void PrintActiveArea(List<string> cardsInHand, int indexOfSelectedPosition )
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
                var pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    if (_currentPlayer == 1 && _currentZone == 1)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = 2;
                            _currentIndex = _upperPlayerCardsInHand.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == 1 && _currentZone == 2)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = 1;
                            _currentIndex = _upperPlayerCardsOnBoard.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == 2 && _currentZone == 1)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = 2;
                            _currentIndex = _lowerPlayerCardsInHand.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    else if (_currentPlayer == 2 && _currentZone == 2)
                    {
                        if (_currentIndex == 0)
                        {
                            _currentZone = 1;
                            _currentIndex = _lowerPlayerCardsOnBoard.Count - 1;
                        }
                        else
                        {
                            _currentIndex--;
                        }
                    }
                    Print(_currentPlayer,_currentZone,_currentIndex);
                }
                if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    if (_currentPlayer == 1 && _currentZone == 1)
                    {
                        if (_currentIndex == _upperPlayerCardsInHand.Count - 1)
                        {
                            _currentZone = 2;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == 1 && _currentZone == 2)
                    {
                        if (_currentIndex == _upperPlayerCardsOnBoard.Count -1)
                        {
                            _currentZone = 1;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == 2 && _currentZone == 1)
                    {
                        if (_currentIndex == _lowerPlayerCardsInHand.Count - 1)
                        {
                            _currentZone = 2;
                            _currentIndex = 0;
                        }
                        else
                        {
                            _currentIndex++;
                        }
                    }
                    else if (_currentPlayer == 2 && _currentZone == 2)
                    {
                        if (_currentIndex == _lowerPlayerCardsOnBoard.Count - 1)
                        {
                            _currentZone = 1;
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
                    if (_currentPlayer == 1)
                    {
                        _currentPlayer = 2;
                        _currentZone = 1;
                        _currentIndex = 0;
                        
                    }
                    else if (_currentPlayer == 2)
                    {
                        _currentPlayer = 1;
                        _currentZone = 1;
                        _currentIndex = 0;
                    }
                    Print(_currentPlayer, _currentZone, _currentIndex);
                }
            }
        }

        public void Print(int playerNumber, int typeOfAction, int index)
        {
            Console.Clear();
            if (playerNumber == 1)
            {
                if (typeOfAction == 1)
                {
                    PrintUpperPlayer(index);
                    PrintActiveArea(_upperPlayerCardsInHand,-1);
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
                if (typeOfAction == 1)
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