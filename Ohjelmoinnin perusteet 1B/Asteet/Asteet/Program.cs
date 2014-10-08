using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna lämpötila Fahrenheit-asteina: ");
            int fahrenheit = int.Parse(Console.ReadLine());

            // C = 5 * ( F – 32 ) / 9.0
            double celcius = 5 * (fahrenheit - 32) / 9.0;

            Console.WriteLine("{0} F = {1:F0} C", fahrenheit, celcius);
        }
    }
}
