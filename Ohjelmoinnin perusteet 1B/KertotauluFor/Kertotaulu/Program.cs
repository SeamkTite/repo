using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Minkä luvun kertotaulu tulostetaan: ");
            int luku = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, luku, i * luku); 
            }
            
        }
    }
}
