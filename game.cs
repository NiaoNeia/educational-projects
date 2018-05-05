using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        class StoneScissorPaper
        {
            public List<string> Variants = new List<string> { "stone", "scissors", "paper" };

            public void Throw(List<string> Variants, out string result)
            {
                var rnd = new Random();
                Thread.Sleep(1000);
                result = Variants[rnd.Next(0, 2)];
                Console.Out.WriteLine("Computers turn is...{0}",result);
            }
        }

        public static string Vvod ()
        {
            Console.Out.WriteLine("Your Turn! Vvedite stone or scissors or paper");
            
            while(true)
            {
                var vvod = Console.ReadLine();
                if (vvod == "stone" || vvod == "scissors" || vvod == "paper") return vvod;
                Console.WriteLine("Наркоман штоле");
            }
            
        }
        static void Main(string[] args)
        {

            var PlayersTurn = Vvod();
            
            var Game = new StoneScissorPaper();
            string result;
            Game.Throw(Game.Variants,out result);
            if (PlayersTurn==result)
            {
                Console.Out.WriteLine("Draw!");
            }
            else if((PlayersTurn=="stone"&&result=="scissors") || (PlayersTurn == "scissors" && result == "paper") || (PlayersTurn == "paper" && result == "stone"))
            {
                Console.Out.WriteLine("You win!");
            }
            else
            {
                Console.Out.WriteLine("You Lose");
            }
            Console.ReadLine();
        }
    }
}
