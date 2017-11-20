using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class OnePlayerGame : PlayerPick
    {
        public string playerOne;
        public string comPlayer;

        public void PlayerOneStart()
        {
            Console.WriteLine("Player 1's turn");
            //base.PromptChoice();
            this.playerOne = base.PromptChoice();
        }           
    }
}
