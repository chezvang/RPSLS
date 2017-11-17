using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class StartGame
    {
        public string playerChoice;

        public void PlayChoice()
        {
            Console.WriteLine("How many players are playing? \n Enter '1' or '2' ." );
                playerChoice = Console.ReadLine();
            PlayDecision(playerChoice);
        }
        //1 player  vs com
        //1 player vs 2 player
        public void PlayDecision(string playerChoice)
        {
            switch(playerChoice)
            {
                case "1": //int or string
                    Console.WriteLine("You have choosen a 1 player game");
                    break;
                case "2":
                    Console.WriteLine("You have choosen a 2 player game");
                    break;
                default:
                    Console.WriteLine("Please choose the number of players.");
                    PlayChoice();
                    break;
            }
        }
    }
}
