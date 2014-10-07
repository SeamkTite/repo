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
            int a, b;
            int tulos;

            a = 5;
            b = 3;

            tulos = a * b;

            Console.WriteLine(tulos);
            Console.WriteLine("Lukujen {0} ja {1} tulo on {2}", a, b, tulos);
            Console.WriteLine("{0} * {1} = {2}", a, b, tulos);
        }
    }
}
