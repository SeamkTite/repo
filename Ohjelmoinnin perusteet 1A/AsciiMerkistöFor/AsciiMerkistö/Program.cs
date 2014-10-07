using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiMerkistö
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma tulostaa kaikki ASCII-merkit
            for (int i = 0; i < 256; i++)
            {
                char c = (char)i;
                if (i != 7) // jätetään BELL pois
                    Console.WriteLine("{0} 0x{1:X} {2}", i, i, c);                
            }
        }
    }
}
