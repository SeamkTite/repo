using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometrikorvaus
{
    class Program
    {
        static void Main(string[] args)
        {
            // 25.	Ohjelma laskee vuosikilometrikorvauksen määrän.
            // Korvaus määräytyy siten, että ekalta 5000 kilometriltä
            // korvaus on 43 senttiä ja ylimeneviltä 30 senttiä.
            Console.Write("Paljonko ajoit vuoden aikana: ");
            int kilometrit = int.Parse(Console.ReadLine());

            double korvaus;
            if (kilometrit < 5000)
            {
                korvaus = kilometrit * 0.43;
            }
            else
            {
                korvaus = 5000 * 0.43 + (kilometrit - 5000) * 0.30;                
            }
            Console.WriteLine("Kilometrikorvaus on {0:F2} euroa", korvaus);
        }
    }
}
