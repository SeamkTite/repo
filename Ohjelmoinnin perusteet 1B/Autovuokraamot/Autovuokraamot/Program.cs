using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autovuokraamot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuorokausien määrä: ");
            int vuorokaudet = int.Parse(Console.ReadLine());

            Console.Write("Arvioitu kilometrimäärä: ");
            double kilometrit = double.Parse(Console.ReadLine()); // voi olla myös int

            // lasketaan vuokra molemmille vuokraamoille
            double vuokraA = vuorokaudet * 110;
            double vuokraB = vuorokaudet * 50 + 0.60 * kilometrit;

            Console.WriteLine("Vuokraamo A: {0:F2} euroa", vuokraA);
            Console.WriteLine("Vuokraamo B: {0:F2} euroa", vuokraB);

            if (vuokraA < vuokraB)
                Console.WriteLine("A halvempi");
            else
                Console.WriteLine("B halvempi");
        }
    }
}
