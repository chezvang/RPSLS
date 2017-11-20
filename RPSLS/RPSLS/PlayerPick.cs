using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    //parent class to hold result 1 - 5
        //1-rock
        //2-paper
        //3-scissors
        //4-lizard
        //5-spock
    class PlayerPick
    {
        public string playerChoice;
        public string player; //used for announcing player

        public virtual string PromptChoice()
        {
            Console.WriteLine("\n Choices: \n 1. Rock \n 2. Paper \n 3. Scissors \n 4. Lizard \n 5. Spock\nChoose your weapon:");
            string playerChoice = Console.ReadLine();
            AnnounceDecision(playerChoice);
            return playerChoice;
        }

        public void AnnounceDecision(string playerChoice)
        {
            switch (playerChoice)
            {
                case "1":
                    Console.WriteLine("You choose Rock\n");
                    break;
                case "2":
                    Console.WriteLine("You choose Paper\n");
                    break;
                case "3":
                    Console.WriteLine("You choose Scissors\n");
                    break;
                case "4":
                    Console.WriteLine("You choose Lizard\n");
                    break;
                case "5":
                    Console.WriteLine("You choose Spock\n");
                    break;
                default:
                    Console.WriteLine("Please choose a number.\n");
                    PromptChoice();
                    break;
            }
        }
    }
}
