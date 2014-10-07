using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karkausvuosi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosi: ");
            int vuosi = int.Parse(Console.ReadLine());

            bool onkoKarkausvuosi;

            if (vuosi % 400 == 0)
                onkoKarkausvuosi = true;
            else if (vuosi % 100 == 0)
                onkoKarkausvuosi = false;
            else if (vuosi % 4 == 0)
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
