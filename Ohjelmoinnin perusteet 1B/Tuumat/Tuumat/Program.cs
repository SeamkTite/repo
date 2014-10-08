using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuumat
{
    class Program
    {
        static void Main(string[] args)
        {
            // ohjelma tekee muunnostaulukon tuumista senteiksi
            int alku = 1;
            int loppu = 10;

            int tuumat = alku;

            while (tuumat <= 10)
            {
                double cm = 2.54 * tuumat;
                Console.WriteLine("{0,3}\" {1,10:F2} cm", tuumat, cm);
                tuumat++;
            }
        }
    }
}
