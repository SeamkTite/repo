using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Y:\Makela_Petteri\TITE14\Ohjelmoinnin perusteet 1A\Keskiarvo\Keskiarvo

namespace Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;
            int lkm = 0;
            int summa = 0;
            int suurinLuku = int.MinValue; // alustetaan pienellä luvulla
            while (true)
            {
                Console.Write("Anna luku: ");
                luku = int.Parse(Console.ReadLine());
                if (luku < 0)
                    break; // lopettaa toistolauseen tähän paikkaan
                if (luku > suurinLuku)
                    suurinLuku = luku;

                //summa = summa + luku;
                summa += luku;
                lkm++;
            }
            Console.WriteLine("Suurin luku oli {0}", suurinLuku);
            Console.WriteLine("Käyttäjä antoi {0} lukua", lkm);
            Console.WriteLine("Annettujen lukujen summa on {0}", summa);
            double keskiarvo = summa / (double)lkm;
            Console.WriteLine("Annettujen lukujen keskiarvo on {0:F1}", keskiarvo);
        }
    }
}
