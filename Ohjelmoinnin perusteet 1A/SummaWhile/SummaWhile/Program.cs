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
            // lasketaan lukujen 1...100 summa
            int i = 1;
            int summa = 0;
            while (i <= 100)
            {
                //summa = summa + i;
                summa += i;
                i++;
            }
            Console.WriteLine("Summa on " + summa);
            // keskiarvo
            double keskiarvo = summa / 100.0;
            Console.WriteLine("Keskiarvo on " + keskiarvo);
        }
    }
}
