using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 1;
                int scoreCPU = 1;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
                    string inputPlayer = Console.ReadLine().ToLower();

                    Random rnd = new Random();
                    int randomInt = rnd.Next(1, 4);
                    string inputCPU;

                    switch (randomInt)
                        {
                            case 1:
                                inputCPU = "ROCK";
                                Console.WriteLine("Computer chose ROCK");
                                if (inputPlayer == "rock") // compare with lowercase value
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "paper")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "scissors")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 2:
                                inputCPU = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "paper") // compare with lowercase value
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "rock")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                else if (inputPlayer == "scissors")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3:
                                inputCPU = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                if (inputPlayer == "scissors") // compare with lowercase value
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "rock")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "paper")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreCPU++;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid entry!");
                                break;
                        }

                    Console.WriteLine($"Player score: {scorePlayer} - CPU score: {scoreCPU}\n");
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine().ToLower();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    playAgain = false;
                }

            }
        }
    }
}
