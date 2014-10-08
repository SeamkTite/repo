using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskukone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku 1: ");
            double luku1 = double.Parse(Console.ReadLine());

            Console.Write("Anna luku 2: ");
            double luku2 = double.Parse(Console.ReadLine());

            Console.Write("Operaatio: ((+, -, *,^, /)");
            char operaatio = char.Parse(Console.ReadLine());

            double tulos = 0;

            switch (operaatio)
            {
                case '+':
                    tulos = luku1 + luku2;
                    break;
                case '-':
                    tulos = luku1 - luku2;
                    break;
                case '*':
                    tulos = luku1 * luku2;
                    break;                
                case '/':
                    tulos = luku1 / luku2;
                    break;
                case 'p':
                case '^':
                    tulos = Math.Pow(luku1, luku2);
                    break;
                default:
                    tulos = 0;
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", luku1, operaatio, luku2, tulos);
        }
    }
}
