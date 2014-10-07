using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodiTesti1
{
    class Program
    {
        static void Main(string[] args)
        {
            // metodin kutsu
            Tervehdi();
            //Hello();
            Tervehdi();

        }

        static void Tervehdi()
        {
            Console.WriteLine("Terve");
            Hello();
        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
