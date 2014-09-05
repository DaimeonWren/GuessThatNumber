using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promt the user for input
            Console.WriteLine("Please input the dice to roll & the number of sides e.g. \"5d6\" ");
            // We call our roll die function
            RollDie(Console.ReadLine());
            // Keep the console open so we may review 
            GTN();

            Console.ReadKey();
        }
        /// <summary>
        /// Rolls a die that specified by the input
        /// </summary>
        /// <param name="input"></param>
        static void RollDie(string input)
        {
            // split the input into our roll count and die sides
            string[] splitIn = input.Split(' ');
            for (int j = 0; j < splitIn.Length; j++)
            {
                string[] split = splitIn[j].Split('d');
                // we parse the the first index of split into an int
                int rollCount = int.Parse(split[0]);
                // we parse the second index into our die sides 
                int dsides = int.Parse(split[1]);
                int avg = 0;
                // we declare a a random number generator 
                Random rng = new Random();
                // An empty string for output
                string output = string.Empty;
                // we loop through number of roll counts
                for (int i = 0; i < rollCount; i++)
                {
                    // we add the roll to our output
                    int roll = rng.Next(1, dsides + 1);
                    output += roll + " ";
                    avg += roll;


                    //outputing output
                }
                avg = avg / rollCount;
                Console.WriteLine("\n" + output + "\nAverage of rolls: " + avg);
            }

        }
   
    }
}

