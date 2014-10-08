using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaattorit
{
    class Program
    {
        static void Main(string[] args)
        {
            // yhteenlasku
            double x = 4 + 5.2;

            // jakolasku
            int a = 5;
            int b = 2;
            double tulos = a / b;
            Console.WriteLine(tulos);

            double desimaalitulos = (double)a / b;
            Console.WriteLine(desimaalitulos);

            // tulos 0
            Console.WriteLine(1/2);

            // tulos 0.5
            Console.WriteLine(1.0 / 2);

            // jakojäännös
            int r = a % b;
            Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}", a, b, r);
        }
    }
}
