using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Winner
    {
        public void AnnounceWinner(int onePoint, int twoPoint)
        {
            if(onePoint > twoPoint)
            {
                Console.Clear();
                Console.WriteLine("Player 1 wins the game!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Player 2 wins the game!");
            }
        }
    }
}
