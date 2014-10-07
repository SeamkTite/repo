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
            int i = 0;
            while (i < 256)
            {
                char c = (char)i;
                if (i != 7)
                    Console.WriteLine("{0} 0x{1:X} {2}", i, i, c);
                i++;
            }

        }
    }
}
