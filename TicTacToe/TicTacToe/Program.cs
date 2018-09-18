using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static string[] position = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static int playerQueue = 1;
        static int choice;
        static int flag = 0;

        static void Board()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2} ", position[1], position[2], position[3]);
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", position[4], position[5], position[6]);
            Console.WriteLine("-----------------");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", position[7], position[8], position[9]);
        }

        private static int CheckWinner()
        {
            if (position[1] == position[2] && position[2] == position[3])
            {
                return 1;
            }
            else if (position[4] == position[5] && position[5] == position[6])
            {
                return 1;
            }
            else if (position[7] == position[8] && position[8] == position[9])
            {
                return 1;
            }

            else if (position[1] == position[4] && position[4] == position[7])
            {
                return 1;
            }
            else if (position[2] == position[5] && position[5] == position[8])
            {
                return 1;
            }
            else if (position[3] == position[6] && position[6] == position[9])
            {
                return 1;
            }

            else if (position[1] == position[5] && position[5] == position[9])
            {
                return 1;
            }
            else if (position[3] == position[5] && position[5] == position[7])
            {
                return 1;
            }

            else if (position[1] != "1" && position[2] != "2" && position[3] != "3" && position[4] != "4" &&
                position[5] != "5" && position[6] != "6" && position[7] != "7" && position[8] != "8" && position[9] != "9")
            {
                return 0;
            }
            else
            {
                return -1;
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            do
            {
                if (playerQueue % 2 == 1)
                {
                    Console.WriteLine("Player 1 turn");
                }
                else
                {
                    Console.WriteLine("Player 2 turn");
                }
                Console.WriteLine("\n");
                Board();
                choice = int.Parse(Console.ReadLine());
                if (position[choice] != "X" && position[choice] != "O")
                {
                    if (playerQueue % 2 == 1)
                    {
                        position[choice] = "X";
                        playerQueue++;
                    }
                    else
                    {
                        position[choice] = "O";
                        playerQueue++;
                    }
                }
                else
                {
                    Console.WriteLine("isn'n empty");
                    Thread.Sleep(1000);
                }
                flag = CheckWinner();

            } while (flag != 1 && flag != 0);

            Board();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (playerQueue % 2) + 1);
            }
            else  //if (flag == 0)
            {
                Console.WriteLine("Draw");
            }
            Thread.Sleep(4000);
        }
    }
}
