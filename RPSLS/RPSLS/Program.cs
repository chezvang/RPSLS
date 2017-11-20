using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            //can be 2 player or 1 player vs com game
            StartGame playChoice = new StartGame();
            playChoice.PlayChoice();

            //OnePlayerGame playGame = new OnePlayerGame();
            //playGame.PlayCheck();

            //PlayerPick player = new PlayerPick();
            //player.PromptDecision();

            //computer roll, if 1 player
            ComPick pick = new ComPick();
            pick.ComputerPick();

            Console.ReadKey();
                //each player rolls
                //random number generator 1 - 5
                    //1 rock
                    //2 paper
                    //3 scissors
                    //4 lizard
                    //5 spock
            //resolution
                //picks winner or tie
                //if tie, players roll again
                //3 out of 5 to win
            //play again?
            
        }
    }
}
