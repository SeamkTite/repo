using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna etunimi: ");
            string etunimi = Console.ReadLine();

            Console.Write("Anna sukunimi: ");
            string sukunimi = Console.ReadLine();

            Console.Write("Anna syntymävuosi: ");
            string s = Console.ReadLine();
            int syntVuosi = int.Parse(s);

            // nykyinen vuosi
            DateTime now = DateTime.Now;
            int nykVuosi = now.Year;

            // lasketaan ikä
            int ika = nykVuosi - syntVuosi;

            string kokonimi = etunimi + " " + sukunimi + " " + ika + " v";

            Console.WriteLine();
            Console.WriteLine(kokonimi);
            Console.WriteLine();
            kokonimi = sukunimi + ", " + etunimi;
            Console.WriteLine(kokonimi);
            Console.WriteLine();


        }
    }
}
