using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTN2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void GTN()
        {
            Random rng = new Random();
            int compNum = rng.Next(1, 101);
            int guesses = 1;
            bool guessing = true;


            while (guessing)
            {
                string zinput = Console.ReadLine();
                int playerguess = int.Parse(zinput);
                if (playerguess > compNum)
                {
                    guesses++;
                    Console.WriteLine("Your guess was a bit to high");
                }
                else if (playerguess < compNum)
                {
                    guesses++;
                    Console.WriteLine("Your guess was a bit to low");
                }
                else
                {
                    guessing = false;
                    Console.WriteLine("Wow! Great guess, you got me.");
                }

            }
        }
    }
}
