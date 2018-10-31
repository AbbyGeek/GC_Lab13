using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab13
{
     class PlayerOne : Player
    {
        
        

        public PlayerOne() : base()
        {

        }

        public override RockPaperScissors GenerateValue()
        {
            //Array values = Enum.GetValues(typeof(RockPaperScissors));
            return RockPaperScissors.rock;
            // return ((RockPaperScissors)0).ToString();

           
        }

    }
}
