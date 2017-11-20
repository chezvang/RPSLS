using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class TwoPlayerGame : PlayerPick
    {
        public string playerOne;
        public string playerTwo;
        public int onePoint;
        public int twoPoint;
        public int totalPoints;

        public void PlayerOneStart(int onePoint, int twoPoint)
        {
            Console.WriteLine("Player 1's turn");
            this.playerOne = base.PromptChoice();
            PlayerTwoStart(onePoint, twoPoint);
        }

        public void PlayerTwoStart(int onePoint, int twoPoint)
        {
            Console.WriteLine("Player 2's turn");
            this.playerTwo = base.PromptChoice();
            PickResolution(onePoint, twoPoint);
        }

        public void PickResolution(int onePoint, int twoPoint)
        {
            PlayerPickResult resolution = new PlayerPickResult();
            resolution.PickConversion(onePoint, twoPoint, playerOne, playerTwo);
        }

        public void PointTracker(int onePoint, int twoPoint, Boolean oneScore, Boolean twoScore)
        {
            if (oneScore == true)
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
            if (totalPoints < 5)
            {
                PlayerOneStart(onePoint, twoPoint);
            }
            else
            {
                Winner winner = new Winner();
                winner.AnnounceWinner(onePoint, twoPoint);
            }
        }
    }
}
