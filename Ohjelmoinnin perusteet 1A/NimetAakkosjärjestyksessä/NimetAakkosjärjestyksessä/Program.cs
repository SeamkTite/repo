using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimetAakkosjärjestyksessä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimi");
            string nimi1 = Console.ReadLine();

            Console.WriteLine("Anna nimi");
            string nimi2 = Console.ReadLine();

            // verrataan merkkijonoja
            int tulos = nimi1.CompareTo(nimi2);
            Console.WriteLine("vertailu tulos on " + tulos);

            if (tulos == 0)
                Console.WriteLine("Samat nimet");
            else if (tulos < 0)
                Console.WriteLine(nimi1 + " on ensin aakkosjärjestyksessä");
            else
                Console.WriteLine(nimi2 + " on ensin aakkosjärjestyksessä");

        }
    }
}
