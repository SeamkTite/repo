using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 10;
            int luku2 = 20;

            int summa = luku1 + luku2;
            Console.WriteLine(summa);
            Console.WriteLine("Lukujen summa on " + summa);
            Console.WriteLine("Lukujen summa on {0}", summa);

            Console.WriteLine("Lukujen {1} ja {2} summa on {0}", summa, luku1, luku2);
        }
    }
}
