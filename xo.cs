using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] gameField = {"1", "2", "3", "4", "5", "6", "7", "8", "9" };

            void DisplayGameBoard()
            {
                Console.WriteLine($"{gameField[0]} | {gameField[1]} | {gameField[2]}");
                Console.WriteLine("----------");
                Console.WriteLine($"{gameField[3]} | {gameField[4]} | {gameField[5]}");
                Console.WriteLine("----------");
                Console.WriteLine($"{gameField[6]} | {gameField[7]} | {gameField[8]}\n\n");
            }

            bool CheckForWinner()
            {
                return (gameField[0] == gameField[1] && gameField[1] == gameField[2]) ||
                       (gameField[3] == gameField[4] && gameField[4] == gameField[5]) ||
                       (gameField[6] == gameField[7] && gameField[7] == gameField[8]) ||
                       (gameField[0] == gameField[3] && gameField[3] == gameField[6]) ||
                       (gameField[1] == gameField[4] && gameField[4] == gameField[7]) ||
                       (gameField[2] == gameField[5] && gameField[5] == gameField[8]) ||
                       (gameField[0] == gameField[4] && gameField[4] == gameField[8]) ||
                       (gameField[2] == gameField[4] && gameField[4] == gameField[6]);
            }


            void StartGame()
            {
                string currentPlayer = "x";
                byte moveCount = 0;
                bool hasError = false;
                while (true)
                {
                    Console.Clear();
                    DisplayGameBoard();
                    if (hasError)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный ввод");
                        Console.ResetColor();
                        hasError = false;
                    }

                    if (moveCount == 9)
                    {
                        Console.WriteLine("Ничья");
                        break;
                    }

                    if (CheckForWinner())
                    {
                        if (currentPlayer == "x")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Игрок 'о' выйграл!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Игрок 'x' выйграл!");
                            Console.ResetColor();
                        }

                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Ход игрока {currentPlayer}");
                        string playerMove = Console.ReadLine();
                        bool isValidMove = false;
                        foreach (string cell in gameField)
                        {
                            if (cell == playerMove)
                            {

                                isValidMove = true;
                                break;
                            }
                        }

                        if (isValidMove)
                        {

                            if (currentPlayer == "x")
                            {
                                gameField[Convert.ToByte(playerMove) - 1] = "x";
                                currentPlayer = "o";
                            }
                            else
                            {
                                gameField[Convert.ToByte(playerMove) - 1] = "o";
                                currentPlayer = "x";
                            }

                            moveCount++;
                        }

                        else
                        {
                            hasError = true;
                        }
                    }
                }
                Console.WriteLine("Сыграем еще? Enter - да, любая клавиша для выхода");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain == "")
                {
                    for (byte i = 1; i < 10; i++)
                    {
                        gameField[i - 1] = Convert.ToString(i);
                    }
                    StartGame();

                }
                else
                {
                    Console.WriteLine("Пока");
                }
            }

            StartGame();
        }
        }
    }
}
