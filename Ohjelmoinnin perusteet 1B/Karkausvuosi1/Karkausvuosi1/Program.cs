using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkausvuosi1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Anna vuosiluku: ");
                //int vuosi = int.Parse(Console.ReadLine());

                int vuosi;
                if (!int.TryParse(Console.ReadLine(), out vuosi))
                    break; // lopettaa while-toistolauseen

                bool onkoKarkausvuosi = false;
                if ((vuosi % 4 == 0) && (vuosi % 100 != 0 || vuosi % 400 == 0))
                    onkoKarkausvuosi = true;
                /*
                if (vuosi % 400 == 0)
                    onkoKarkausvuosi = true;
                else if (vuosi % 100 == 0)
                    onkoKarkausvuosi = false;
                else if (vuosi % 4 == 0)
                    onkoKarkausvuosi = true;
                else
                    onkoKarkausvuosi = false;
                 */

                if (onkoKarkausvuosi)
                {
                    Console.WriteLine("Vuosi {0} on karkausvuosi", vuosi);
                }
                else
                {
                    Console.WriteLine("Vuosi {0} ei ole karkausvuosi", vuosi);
                }
            }
        }
    }
}
