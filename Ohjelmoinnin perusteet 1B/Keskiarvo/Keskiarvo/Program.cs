using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keskiarvo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int summa = 0;

            int pieninLuku = int.MaxValue;
            int suurinLuku = int.MinValue;

            while (true)
            {
                Console.Write("Anna luku: ");
                int luku = int.Parse(Console.ReadLine());

                if (luku == 0)
                    break; // toisto loppuu tähän

                if (luku < pieninLuku)
                {
                    pieninLuku = luku;
                }
                if (luku > suurinLuku)
                {
                    suurinLuku = luku;
                }

                //summa = summa + luku;
                summa += luku;
                i++;
            }
            Console.WriteLine("Pienin: " + pieninLuku);
            Console.WriteLine("Suurin: " + suurinLuku);
            // keskiarvon laskenta
            double keskiarvo = summa / (double)i;
            Console.WriteLine("Keskiarvo on {0:F1}", keskiarvo);
        }
    }
}
