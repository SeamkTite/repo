using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // lasketaan summa käyttäjän antamista luvuista
            int summa = 0;
            int i = 0;
            int luku;
            do
            {
                Console.Write("Anna luku:");
                luku = int.Parse(Console.ReadLine());
                summa += luku;
            } while (luku != 0);
            Console.WriteLine("Summa on {0}", summa);
        }
    }
}
