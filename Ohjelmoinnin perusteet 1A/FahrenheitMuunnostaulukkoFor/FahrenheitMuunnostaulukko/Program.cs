using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitMuunnostaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            // tee ohjelma, joka tekee muunnostaulukon Fahrenheit-
            // ja Celcius-asteiden välillä. Aloita 0F ja jatka 100F asti,
            // 10F välein

            for (int fahr = 0; fahr <= 100; fahr += 10)
            {
                double celcius = (fahr - 32) / 1.8;
                Console.WriteLine("{0} F = {1:F1} C", fahr, celcius);               
            }

        }
    }
}
