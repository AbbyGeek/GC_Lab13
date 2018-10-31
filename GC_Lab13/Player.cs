using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab13
{
    public abstract class Player
    {
        public string Name { set; get; }
        public RockPaperScissors Value { set; get; }

        public Player()
        {
           
        }

        public abstract RockPaperScissors GenerateValue();
        

        
        

        
        
    }
}
