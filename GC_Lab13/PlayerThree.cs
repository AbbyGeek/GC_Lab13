using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab13
{
    class PlayerThree : Player
    {

        public override RockPaperScissors GenerateValue()
        {
            while (true)
            {
                try
                {
                    //Array values = Enum.GetValues(typeof(RockPaperScissors));
                    Console.WriteLine("\nChoose wisely....");
                    Console.WriteLine("Rock?---Paper?---Scissors?");

                    string pick = Console.ReadLine().ToLower();

                    Enum.TryParse(pick, out RockPaperScissors choice);

                    if (!Enum.IsDefined(typeof(RockPaperScissors), pick)) { Console.WriteLine("Invalid entry. Please try again"); continue; }

                    return choice;
                }
                catch { Console.WriteLine("Invalid entry. Try again."); continue; }
                }
        }
    }
}
