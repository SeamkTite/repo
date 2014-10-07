using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneDice
{
    class Program
    {
        static void Main(string[] args)
        {

            // create and initialize the random number generator
            Random generator = new Random();

            Console.WriteLine("How many times the dice will be thrown?");
            int n = int.Parse(Console.ReadLine());

            int ones = 0;
            int twos = 0;
            int threes = 0;
            int fours = 0;
            int fives = 0;
            int sixs = 0;

            int i = 0;
            while (i < n)
            {
                // throw a dice
                int result = generator.Next(6) + 1;
                
                // increment the counter
                // corresponding the result
                switch (result)
                {
                    case 1:
                        ones++;
                        break;
                    case 2:
                        twos++;
                        break;
                    case 3:
                        threes++;
                        break;
                    case 4:
                        fours++;
                        break;
                    case 5:
                        fives++;
                        break;
                    case 6:
                        sixs++;
                        break;
                }
                i++;
            }
            Console.WriteLine("1: " + (ones / (double)n * 100.0) + " %");
            Console.WriteLine("2: " + (twos / (double)n * 100.0) + " %");
            Console.WriteLine("3: " + (threes / (double)n * 100.0) + " %");
            Console.WriteLine("4: " + (fours / (double)n * 100.0) + " %");
            Console.WriteLine("5: " + (fives / (double)n * 100.0) + " %");
            Console.WriteLine("6: " + (sixs / (double)n * 100.0) + " %");
        }
    }
}
