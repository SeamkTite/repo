using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiihtyväLiike
{
    class Program
    {
        static void Main(string[] args)
        {
            // alkunopeus
            double v0 = 30;
            // aika
            double t = 10.0;
            // kiihtyvyys
            double a = 9.81;
            // matka
            double s = v0 * t + 0.5 * a * t * t;

            Console.WriteLine("Kuljettu matka on {0}", s);

            string nimi = "Petteri";
            Console.WriteLine("Terve " + nimi);
        }
    }
}
