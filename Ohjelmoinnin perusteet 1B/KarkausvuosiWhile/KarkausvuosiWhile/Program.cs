using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarkausvuosiWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mistä vuodesta aloitetaan: ");
            int alku = int.Parse(Console.ReadLine());

            Console.Write("Viimeinen vuosi: ");
            int loppu = int.Parse(Console.ReadLine());

            int vuosi = alku;
            while (vuosi <= loppu)
            {
                if ((vuosi % 4 == 0) && (vuosi % 100 != 0 || vuosi % 400 == 0))
                    Console.WriteLine(vuosi);

                vuosi++;
            }
        }
    }
}
