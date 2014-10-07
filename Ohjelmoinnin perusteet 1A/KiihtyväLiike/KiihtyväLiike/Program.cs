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
            double v0 = 30.4;
            // aika
            double t = 10.122;
            // kiihtyvyys
            double a = 6.5;
            // matka
            double s = v0 * t + 0.5 * a * t * t;

            Console.WriteLine("Kuljettu matka on " + s + " m");
            Console.WriteLine("Kuljettu matka on {0} m", s);
            Console.WriteLine("Kuljettu matka on {0:f1} m", s);
        }
    }
}
