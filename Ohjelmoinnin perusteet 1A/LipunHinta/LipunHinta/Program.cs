using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LipunHinta
{
    class Program
    {
        // 39.	Erääseen esitykseen myydään lippuja siten,
        // että eläkeläinen saa aikuisten lipusta 20%:n alennuksen,
        // opiskelija 40%:n alennuksen
        // ja lapsi 60%: alennuksen.
        // Laadi ohjelma, joka tulostaa ostettavan lipun hinnan.
        // Käytä ratkaisussa switch-case rakennetta.
        static void Main(string[] args)
        {
            double lipunHinta = 20;
            Console.WriteLine("Oletko opiskelija (1)");
            Console.WriteLine("Oletko eläkeläinen (2)");
            Console.WriteLine("Oletko lapsi (3)");
            Console.WriteLine("Muu (4)");
            int tyyppi = int.Parse(Console.ReadLine());

            double alennus = 0;
            switch (tyyppi)
            {
                case 1:
                    alennus = lipunHinta * 0.4;
                    break;
                case 2:
                    alennus = lipunHinta * 0.6;
                    break;
                case 3:
                    alennus = lipunHinta * 0.2;
                    break;
                default:
                    break;
            }
            lipunHinta -= alennus;
            //lipunHinta = lipunHinta - alennus;
            Console.WriteLine("Lipun hinta on {0:F2}", lipunHinta);

        }
    }
}
