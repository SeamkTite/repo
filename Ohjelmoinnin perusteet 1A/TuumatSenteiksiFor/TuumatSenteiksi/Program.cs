using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuumatSenteiksi
{
    class Program
    {
        static void Main(string[] args)
        {
            // tee ohjelma, joka tulostaa muunnostaulukon tuumista senteiksi
            // välillä 1...10 yhden tuuman välein
            int tuumat = 1;
            
            while (tuumat <= 10)
            {
                double cm = 2.54 * tuumat;
                Console.WriteLine("{0} tuumaa = {1:F2}", tuumat, cm);
                tuumat++;
            }
            Console.WriteLine("................................");

            // sama for-lauseella
            for (tuumat = 1; tuumat <= 10; tuumat++)
            {
                double cm = 2.54 * tuumat;
                Console.WriteLine("{0,2} tuumaa = {1,5:F2}", tuumat, cm);               
            }

        }
    }
}
