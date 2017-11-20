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
            this.playerOne = base.PromptChoice();
            ComStart();
        }

        public void ComStart()
        {
            Console.WriteLine("Computer Player's turn.");
            ComRoll();
        }

        public void ComRoll()
        {
            Random random = new Random();
            int comPickResult = random.Next(1, 5);
            this.comPlayer = Convert.ToString(comPickResult);
            ComDecision(comPlayer);
        }

        public void ComDecision(string comPlayer)
        {
            base.AnnounceDecision(comPlayer);
            PickResolution();
        }

        public void PickResolution()
        {
            PlayerPickResult resolution = new PlayerPickResult();
            resolution.PickConversion(playerOne, comPlayer);
            
            //convert strings to int
              //resolve game
              //give point to winner
        }

        public void PointTracker()
        {

        }
    }
}
