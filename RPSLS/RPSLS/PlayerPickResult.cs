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
        public int result;

        public void PickConversion(string one, string two)
        {
            this.playerOne = Convert.ToInt32(one);
            this.playerTwo = Convert.ToInt32(two);
            ResolvePicks();
        }

        public void ResolvePicks()
        {
            playerOne = playerOne - 1;
            playerTwo = playerTwo - 1;
            result = (5 + playerOne - playerTwo) % 5;
            PickWinner(result);
        }

        public void PickWinner(int result)
        {
            switch (result)
            {
                case 1:
                    Console.WriteLine("Player One wins!");
                    PlayerOnePoint();
                    break;
                case 2:
                    Console.WriteLine("Player Two wins!\n");
                    PlayerTwoPoint();
                    break;
                case 3:
                    Console.WriteLine("Player One wins!\n");
                    break;
                case 4:
                    Console.WriteLine("Player Two wins!\n");
                    break;
                default:
                    Console.WriteLine("Tie! No winner.\n");
                    break;
            }
        }

        public void PlayerOnePoint()
        {
            OnePlayerGame score = new OnePlayerGame();
            score.PointTracker(true, false);
        }

        public void PlayerTwoPoint()
        {
            OnePlayerGame score = new OnePlayerGame();
            score.PointTracker(false, true);
        }
    }
}


//rock(1) > scissor(3)