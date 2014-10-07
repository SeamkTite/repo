using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertotaulu1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Minkä luvun kertotaulu tulostetaan: ");
            int luku = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= 10)
            {
                int tulos = i * luku;
                Console.WriteLine("{0} * {1} = {2}", i, luku, tulos);
                i++;
            }
        }
    }
}
