using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayttajanIka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Anna syntymävuosi: ");
            int syntVuosi = int.Parse(Console.ReadLine());

            // nykyinen ajanhetki
            DateTime nyt = DateTime.Now;
            // nykyinen vuosi
            int nykVuosi = nyt.Year;

            // lasketaan ikä
            int ika = nykVuosi - syntVuosi;

            Console.WriteLine("Terve " + nimi + "! Olet " + ika + " vuotta vanha");
            Console.WriteLine("Terve {0}! Olet {1} vuotta vanha", nimi, ika);
        }
    }
}
