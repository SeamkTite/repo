using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkausvuosi3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Anna vuosi: ");
                string s = Console.ReadLine(); // luetaan käyttäjän syöte tekstinä
                int vuosi;

                // yritetään muuttaa numeroksi
                if (!int.TryParse(s, out vuosi))
                    break; // hyppää while-silmukasta pois

                bool onkoKarkausvuosi;

                if (vuosi % 400 == 0 || ((vuosi % 4 == 0) && (vuosi % 100 != 0)))
                    onkoKarkausvuosi = true;
                else
                    onkoKarkausvuosi = false;

                if (onkoKarkausvuosi)
                    Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
                else
                    Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
            }
        }
    }
}
