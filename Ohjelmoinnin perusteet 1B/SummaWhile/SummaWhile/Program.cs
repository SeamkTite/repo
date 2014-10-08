using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma laskee lukujen 1...100 summan ja keskiarvon
            int i = 1;
            int summa = 0;
            while (i <= 100)
            {
                //summa = summa + i;
                summa += i;
                i++;
            }
            Console.WriteLine("Summa on {0}", summa);
            double keskiarvo = summa / 100.0;
            Console.WriteLine("Keskiarvo on {0:F1}", keskiarvo);
        }
    }
}
