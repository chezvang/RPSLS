using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class PlayerPickResult
    {
        public int playerOne;
        public int playerTwo;
        public int placeholder;

        public void PickConversion(string one, string two)
        {
            this.playerOne = Convert.ToInt32(one);
            this.playerTwo = Convert.ToInt32(two);
            ResolvePicks();
        }

        public void ResolvePicks()
        {
            placeholder = playerOne - playerTwo;
            Console.WriteLine(placeholder);
        }


    }
}


//rock(1) > scissor(3)