using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIITaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma tulostaa ASCII-taulukon merkit välillä 0...127
            int i = 0;
            while (i < 128)
            {
                char merkki = (char)i;
                if (i != 7)
                {
                    Console.WriteLine("{0,3} {1,3:X} {2}", i, i, merkki);
                }
                i++;
            }
        }
    }
}
