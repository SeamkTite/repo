using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gondoli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ryhmän koko: ");
            int ryhmanKoko = int.Parse(Console.ReadLine());

            // viimeiseen hissin henkilömäärä on jakojäännös ryhmän koosta ja gondolin koosta
            int viimeisenLkm = ryhmanKoko % 8;
            Console.WriteLine("Viimeiseen hissiin jää {0} henkilöä", viimeisenLkm);
           
        }
    }
}
