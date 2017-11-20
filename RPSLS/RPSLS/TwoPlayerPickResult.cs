using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class TwoPlayerPickResult
    {
        public int playerOne;
        public int playerTwo;
        public int result;

        public void PickConversion(int onePoint, int twoPoint, string one, string two)
        {
            this.playerOne = Convert.ToInt32(one);
            this.playerTwo = Convert.ToInt32(two);
            ResolvePicks(onePoint, twoPoint);
        }

        public void ResolvePicks(int onePoint, int twoPoint)
        {
            playerOne = playerOne - 1;
            playerTwo = playerTwo - 1;
            result = (5 + playerOne - playerTwo) % 5;
            PickWinner(onePoint, twoPoint, result);
        }

        public void PickWinner(int onePoint, int twoPoint, int result)
        {
            switch (result)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Player One wins!\n");
                    PlayerOnePoint(onePoint, twoPoint);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Player Two wins!\n");
                    PlayerTwoPoint(onePoint, twoPoint);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Player One wins!\n");
                    PlayerOnePoint(onePoint, twoPoint);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Player Two wins!\n");
                    PlayerTwoPoint(onePoint, twoPoint);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Tie! No winner.\n");
                    PlayerTie(onePoint, twoPoint);
                    break;
            }
        }

        public void PlayerOnePoint(int onePoint, int twoPoint)
        {
            TwoPlayerGame score = new TwoPlayerGame();
            score.PointTracker(onePoint, twoPoint, true, false);
        }

        public void PlayerTwoPoint(int onePoint, int twoPoint)
        {
            TwoPlayerGame score = new TwoPlayerGame();
            score.PointTracker(onePoint, twoPoint, false, true);
        }

        public void PlayerTie(int onePoint, int twoPoint)
        {
            TwoPlayerGame score = new TwoPlayerGame();
            score.PointTracker(onePoint, twoPoint, false, false);
        }
    }
}
