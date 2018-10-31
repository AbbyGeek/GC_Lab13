using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GC_Lab13
{
    class Program
    {
        

        static void Main(string[] args)
        {
            while (true)
            {

                PlayerTwo playerTwo = new PlayerTwo();
                PlayerOne playerOne = new PlayerOne();
                PlayerThree playerThree = new PlayerThree();
                Player choice;

                Console.WriteLine("Welcome to a fun game with a dumb name! Roshambo!");
                Console.WriteLine("We're going to call it Rock Paper Scissors because we aren't squares.");

                Console.WriteLine("Choose your opponent!\nPlayer 1) Only throws rock (easy mode)\nPlayer 2) Throws randomly");
                string opponent = Console.ReadLine();
                Console.WriteLine("(enter 'q' at any time to quit)");


                if (opponent == "1" || opponent.ToLower() == "player 1") { choice = playerOne; }

                else if (opponent == "2" || opponent.ToLower() == "player 2") { choice = playerTwo; }

                else if (opponent == "q") { break; }

                else { Console.WriteLine("Invalid Input. Try Again"); continue; }

                PlayGame(choice, playerThree);
            }
        }
        public static void PlayGame(Player opponent, PlayerThree playerThree)
        {
            int win = 0;
            int loss = 0;
            while (true)
            {
                try
                {
                    // get user's choice
                    RockPaperScissors userPick = playerThree.GenerateValue();
                    Console.WriteLine($"You picked: {userPick}");


                    //get computer's choice (player one or player two)
                    RockPaperScissors computerPick = opponent.GenerateValue();

                    Console.WriteLine($"Your opponent picked: {computerPick}");

                    //determine winner
                    if (userPick == RockPaperScissors.scissors)
                    {
                        if (computerPick == RockPaperScissors.rock) { Console.WriteLine("Computer Wins!"); loss += 1; }
                        else if (computerPick == RockPaperScissors.paper) { Console.WriteLine("User Wins!"); win += 1; }
                        else { Console.WriteLine("Tie!"); }
                    }

                    else if (userPick == RockPaperScissors.paper)
                    {
                        if (computerPick == RockPaperScissors.scissors) { Console.WriteLine("Computer Wins!"); loss += 1; }
                        else if (computerPick == RockPaperScissors.rock) { Console.WriteLine("User Wins!"); win += 1; }
                        else { Console.WriteLine("Tie!"); }
                    }

                    else if (userPick == RockPaperScissors.rock)
                    {
                        if (computerPick == RockPaperScissors.paper) { Console.WriteLine("Computer Wins!"); loss += 1; }
                        else if (computerPick == RockPaperScissors.scissors) { Console.WriteLine("User Wins!"); win += 1; }
                        else { Console.WriteLine("Tie!"); }
                    }
                    else if (userPick == RockPaperScissors.quit) { Console.WriteLine("Goodbye!"); Thread.Sleep(3000); Console.Clear(); ; break; }

                    else { Console.WriteLine("Ya screwed up. Go again"); }
                    Console.WriteLine($"Wins: {win}  Losses: {loss}");
                }
                catch
                {
                    Console.WriteLine("Invalid entry. Try again.");
                    continue;
                }


                
            }

        }
    }
}
