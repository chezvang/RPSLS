using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComPick
    {
        public int comPickResult;
        //public string comResult;

        public virtual void ComputerPick()
        {
            Random random = new Random();

            int comPickResult = random.Next(1, 5);
            ResultChoices(comPickResult);
        }
        
        //may delete for inheritance from PlayerPick
          //PlayerPick will hold results
          //com roll result will move into PlayerPick to pick result of RPSLS
        //use int to resolve choice
        public void ResultChoices(int comPickResult)
        {
            switch(comPickResult)
            {
                case 1:
                    Console.WriteLine("Computer chose Rock");
                    break;
                case 2:
                    Console.WriteLine("Computer chose Paper");
                    break;
                case 3:
                    Console.WriteLine("Computer chose Scissors");
                    break;
                case 4:
                    Console.WriteLine("Computer chose Spock");
                    break;
                default:
                    Console.WriteLine("Computer chose Lizard");
                    break;
            }
        }
    }
}
