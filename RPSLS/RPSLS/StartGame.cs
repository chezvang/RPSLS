﻿using System;
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
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!\nThis game is best out of 5.\n\nHow many players are playing?\nEnter: [1] or [2] " );
            playerChoice = Console.ReadLine();
            PlayDecision(playerChoice);
        }

        public void PlayDecision(string playerChoice)
        {
            switch(playerChoice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("You have choosen a 1 player game");
                    OnePlayerGame game = new OnePlayerGame();
                    game.PlayerOneStart(0, 0);
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("You have choosen a 2 player game");
                    TwoPlayerGame twogame = new TwoPlayerGame();
                    twogame.PlayerOneStart(0, 0);
                    break;
                default:
                    Console.WriteLine("Please choose the number of players.\n");
                    PlayChoice();
                    break;
            }
        }
    }
}
