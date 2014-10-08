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
            // 5.	Tee ohjelma, joka laskee ja
            // tulostaa taksimatkan hinnan.
            // Hintaan vaikuttavat lähtöhinta
            // ja ajettu kilometrimäärä sekä kilometrihinta.

            // kysy ajettu kilometrimäärä käyttäjältä
            // lähtöhinta=10 ja kilometrihinta = 0.5
            Console.Write("Kilometrimäärä: ");
            int kilometrit = int.Parse(Console.ReadLine());

            double lahtoHinta = 10;
            double kmHinta = 0.5;

            double hinta = lahtoHinta + kilometrit * kmHinta;

            Console.WriteLine("Matkan hinta on {0:F2}", hinta);

        }
    }
}
