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
            // ohjelma tulostaa karkausvuodet annetulta väliltä
            Console.Write("Aloitusvuosi: ");
            int alku = int.Parse(Console.ReadLine());

            Console.Write("Lopetusvuosi: ");
            int loppu = int.Parse(Console.ReadLine());

            int vuosi = alku;

            while (vuosi <= loppu)
            {
                if ((vuosi % 400 == 0) || ((vuosi % 4 == 0) && (vuosi % 100 != 0)))
                {
                    Console.Write(vuosi + " ");
                }
                vuosi++;
            }


        }
    }
}
