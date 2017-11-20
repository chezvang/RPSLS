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

        public void PlayerOneStart(int onePoint, int twoPoint)
        {
            Console.WriteLine("Player 1's turn");
            this.playerOne = base.PromptChoice();
            ComStart(onePoint, twoPoint);
        }

        public void ComStart(int onePoint, int twoPoint)
        {
            Console.WriteLine("Computer Player's turn.");
            ComRoll(onePoint, twoPoint);
        }

        public void ComRoll(int onePoint, int twoPoint)
        {
            Random random = new Random();
            int comPickResult = random.Next(1, 5);
            this.comPlayer = Convert.ToString(comPickResult);
            ComDecision(onePoint, twoPoint, comPlayer);
        }

        public void ComDecision(int onePoint, int twoPoint, string comPlayer)
        {
            base.AnnounceDecision(comPlayer);
            PickResolution(onePoint, twoPoint);
        }

        public void PickResolution(int onePoint, int twoPoint)
        {
            PlayerPickResult resolution = new PlayerPickResult();
            resolution.PickConversion(onePoint, twoPoint, playerOne, comPlayer);            
        }

        public void PointTracker(int onePoint, int twoPoint, Boolean oneScore, Boolean twoScore)
        {
            if(oneScore == true)
            {
                onePoint++;
                Console.WriteLine("Player 1: " + onePoint + "\nPlayer 2: " + twoPoint + "\n");
                CheckWinner(onePoint, twoPoint);
            }
            else if (twoScore == true)
            {
                twoPoint++;
                Console.WriteLine("Player 1: " + onePoint + "\nPlayer 2: " + twoPoint + "\n");
                CheckWinner(onePoint, twoPoint);
            }
            else
            {
                Console.WriteLine("It's a tie!\nPlayer 1: " + onePoint + "\nPlayer 2: " + twoPoint + "\n");
                CheckWinner(onePoint, twoPoint);
            }
        }

        public void CheckWinner(int onePoint, int twoPoint)
        {
            totalPoints = onePoint + twoPoint;
            while (totalPoints < 6)
            {
                PlayerOneStart(onePoint, twoPoint);
            }
        }
    }
}
