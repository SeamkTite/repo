using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KertotauluKoe
{
    class Program
    {
        static void Main(string[] args)
        {
            // luo satunnaislukugeneraattori
            Random gen = new Random();
            int oikeitaVastauksia = 0;
            for (int i = 0; i < 10; i++)
            {
                // arvo luku 1
                int luku1 = gen.Next(2, 11);
                // arvo luku 2
                int luku2 = gen.Next(2, 11);

                // tulosta luvut
                Console.Write("{0} * {1} = ", luku1, luku2);
                int vastaus = int.Parse(Console.ReadLine());

                int oikeaVastaus = luku1 * luku2;
                if (vastaus == oikeaVastaus)
                {
                    Console.WriteLine("Oikein!");
                    oikeitaVastauksia++;
                }
                else
                {
                    Console.WriteLine("Väärin!");
                }
            }
            Console.WriteLine("Oikein " + oikeitaVastauksia + " kpl");
        }
    }
}
