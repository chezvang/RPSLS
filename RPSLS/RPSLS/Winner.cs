using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Winner
    {
        public string resetGame;
        public int resetValue;

        public void AnnounceWinner(int onePoint, int twoPoint)
        {
            if(onePoint > twoPoint)
            {
                Console.Clear();
                Console.WriteLine("Player 1 wins the game!\n\nPlayer 1 score: " + onePoint + "\nPlayer 2 score: " + twoPoint);
                AskPlayAgain();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Player 2 wins the game!\n\nPlayer 2 score: " + twoPoint + "\nPlayer 1 score: " + onePoint);
                AskPlayAgain();
            }
        }

        public void AskPlayAgain()
        {
            Console.WriteLine("\nDo you wish to play again? Enter [yes] or [no]");
            resetGame = Console.ReadLine();
            ResetConvert(resetGame);
        }

        public void ResetConvert(string resetGame)
        {
            switch (resetGame)
            {
                case "yes":
                    resetGame = "1";
                    ResetGameConvert(resetGame);
                    break;
                case "no":
                    resetGame = "0";
                    ResetGameConvert(resetGame);
                    break;
                default:
                    Winner reset = new Winner();
                    reset.AskPlayAgain();
                    break;
            }
        }

        public void ResetGameConvert(string resetGame)
        {
            resetValue = Convert.ToInt32(resetGame);
            PlayAgain(resetValue);
        }

        public void PlayAgain(int resetValue)
        {
            if (resetValue == 1)
            {
                Console.Clear();
                StartGame newgame = new StartGame();
                newgame.PlayChoice();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
