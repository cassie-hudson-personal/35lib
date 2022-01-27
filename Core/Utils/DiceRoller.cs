using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class DiceRoller
    {  
        public static int Dice(int sides)
        {
             return new Random().Next(1, sides+1);
        }
    }  
}
