using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitTaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            // muunnostaulukko F->C, väli 0F...100F, askel 10F
            int alku = 0;
            int loppu = 100;
            int askel = 10;

            int fahr = alku; // fahr on laskuri
            while (fahr <= loppu)
            {
                double celcius = (fahr - 32) / 1.8;
                Console.WriteLine("{0,4} F = {1,5:F1} C", fahr, celcius);
                fahr += askel;
            }
        }
    }
}
