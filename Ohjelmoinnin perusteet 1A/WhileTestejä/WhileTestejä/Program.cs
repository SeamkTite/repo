using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTestejä
{
    class Program
    {
        static void Main(string[] args)
        {
            // tulostetaan luvut 0...4
            int i = 0; // laskuri
            while (i < 5)
            {
                Console.Write(i + " ");
                i = i + 1;
            }
            Console.WriteLine();

            // tulostetaan luvut 1...5
            i = 1;
            while (i <= 5)
            {
                Console.Write(i + " ");
                i++; // i += 1;
            }
            Console.WriteLine();

            i = 0;
            while (i <= 20)
            {
                Console.Write(i + " ");
                i += 2;
            }
            Console.WriteLine();

            // tulostetaan kirjaimet a...z
            char c = 'a';
            while (c <= 'z')
            {
                int ascii = c;
                Console.Write(c + " " + ascii + "\n");
                c++;
            }
            Console.WriteLine();
        }
    }
}
