using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tähdet
{
    class Program
    {
        static void Main(string[] args)
        {
            // A) kysy käyttäjältä montako merkkiä tulostetaan
            Console.Write("lukumäärä: ");
            int lkm = int.Parse(Console.ReadLine());

            // B) kysy käyttäjältä mikä merkki tulostetaan
            Console.Write("merkki?: ");
            char merkki = char.Parse(Console.ReadLine());

            // C) tulosta neliö eli yhtä monta riviä kuin saraketta
            int j = 0;
            while (j < lkm)
            {
                int i = 0;
                while (i < lkm)
                {
                    Console.Write(merkki);
                    i++;
                }
                Console.WriteLine();
                j++;
            }
        }
    }
}
