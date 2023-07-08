using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ROCKPAPERSCISSORS
{
    class Program{
        static void Main(string[] args)
        {
            string inputPlayer;
            int randomInt;

            Random rnd = new Random(); 

            int scorePlayer = 0;
            int scoreCPU = 0;
            
            bool playAgain = true;
            while(playAgain)
            {
                while(scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("\n=========================================");
                    Console.WriteLine("Choose between ROCK, PAPER and SCISSORS: ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                    randomInt = rnd.Next(1, 4); // generate [1-3] 1 = ROCK, 2 = PAPER, 3 = SCISSORS
                    judge_winner(ref inputPlayer, randomInt, ref scorePlayer, ref scoreCPU);

                    Console.WriteLine("Player: {0}  CPU: {1}", scorePlayer, scoreCPU);
                }
                if(scorePlayer == 3)
                {
                    Console.WriteLine("+++++Player WON!+++++");
                }
                else if(scoreCPU == 3)
                {
                    Console.WriteLine("-----CPU WON!-----");
                }
                else
                {
                    Console.WriteLine("===DRAW!===");
                }
                // ask if player wants to play again
                playAgain = play_again(ref scorePlayer, ref scoreCPU);
            }

            
        }
        static Boolean play_again(ref int scorePlayer, ref int scoreCPU){
            Console.WriteLine("Do you want to play again? (y/n)");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if(input == "Y"){
                scorePlayer = 0;
                scoreCPU = 0;
                return true;
            }
            else if(input == "N"){
                return false;
            }
            else{
                Console.WriteLine("Invalid input. Please try again.");
                return play_again(ref scorePlayer, ref scoreCPU);
            }
        }
        static void judge_winner(ref string inputPlayer, int inputCPU, ref int scorePlayer, ref int scoreCPU){
            switch(inputCPU)
            {
                case 1:
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("===DRAW!===");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("+++PLAYER WINS!+++");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("---CPU WINS!---");
                        scoreCPU++;
                    }
                    break;

                case 2:
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("---CPU WINS!---");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("===DRAW!===");
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("+++PLAYER WINS!+++");
                        scorePlayer++;
                    }
                    break;

                case 3:
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("+++PLAYER WINS!+++");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("---CPU WINS!---");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("===DRAW!===");
                    }
                    break;
            }
        }
    }
}