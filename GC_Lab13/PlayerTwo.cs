using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab13
{
    class PlayerTwo : Player
    {
        public PlayerTwo() : base()
        {

        }
        
        public override RockPaperScissors GenerateValue()
        {
            Array values = Enum.GetValues(typeof(RockPaperScissors));
            // random number
            Random n = new Random();
            int x = n.Next(3);
            return (RockPaperScissors)x;
        }


    }
}
