using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taksimatka
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.	Tee ohjelma, joka laskee ja tulostaa
            // taksimatkan hinnan.
            // Hintaan vaikuttavat lähtöhinta ja
            // ajettu kilometrimäärä
            // sekä kilometrihinta=0.5.
            Console.Write("Lähtöhinta: ");
            double lahtoHinta = double.Parse(Console.ReadLine());

            Console.Write("KM: ");
            double km = double.Parse(Console.ReadLine());

            double kmHinta = 0.5;

            double hinta = lahtoHinta + km * kmHinta;
            Console.WriteLine("Taksimatkan hinta on {0:F2}", hinta);
        }
    }
}
