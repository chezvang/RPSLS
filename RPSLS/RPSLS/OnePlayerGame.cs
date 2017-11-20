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
        public int onePoint;
        public int twoPoint;
        public int totalPoints;

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
        }

        public void PointTracker(Boolean oneScore, Boolean twoScore)
        {
            if(oneScore == true)
            {
                onePoint++;
                Console.WriteLine("Player 1: " + onePoint + "\nPlayer 2: " + twoPoint + "\n");
                CheckWinner();
            }
            else
            {
                twoPoint++;
                Console.WriteLine("Player 1: " + onePoint + "\nPlayer 2: " + twoPoint + "\n");
                CheckWinner();
            }
        }

        public void CheckWinner()
        {
            totalPoints = onePoint + twoPoint;
            while (totalPoints < 6)
            {
                PlayerOneStart();
            }
        }
    }
}
