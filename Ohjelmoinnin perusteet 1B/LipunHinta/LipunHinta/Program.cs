using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee alennetun lipun hinnan. Oletko");
            Console.WriteLine("Opiskelija = 1");
            Console.WriteLine("Lapsi = 2");
            Console.WriteLine("Eläkeläinen = 3");
            Console.WriteLine("Muu = 4");

            int tyyppi = int.Parse(Console.ReadLine());

            double hinta = 25;
            double alennus;
            switch (tyyppi)
            {
                case 1:
                    alennus = hinta * 0.40;
                    break;
                case 2:
                    alennus = hinta * 0.60;
                    break;
                case 3:
                    alennus = hinta * 0.20;
                    break;
                default:
                    alennus = 0;
                    break;
            }
            Console.WriteLine("Alennus on {0:F2} euroa. Lippu maksaa {1:F2} euroa",
                alennus, hinta - alennus);
        }
    }
}
