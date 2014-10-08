using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KertotauluRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma kysyy 10 kertolaskua käyttäjältä

            int oikeidenLkm = 0;
            Random generaattori = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int luku1 = generaattori.Next(2, 11); // 2...10
                int luku2 = generaattori.Next(2, 11); // 2...10

                Console.Write("{2}: {0} * {1} = ", luku1, luku2, i);
                int vastaus = int.Parse(Console.ReadLine());
                int oikeaVastaus = luku1 * luku2;
                // kerro käyttäjälle, vastasiko hän oikein vai väärin
                if (vastaus == oikeaVastaus)
                {
                    Console.WriteLine("Oikein");
                    oikeidenLkm++;
                }
                else
                {
                    Console.WriteLine("Väärin");
                }        
            }
            // kerro oikeiden vastausten lukumäärä
            Console.WriteLine("Oikeita vastauksia {0} kpl", oikeidenLkm);
        }
    }
}
