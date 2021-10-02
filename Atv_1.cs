using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace testeATV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor em Celsius para transforma em Farh:");
            double x = Convert.ToDouble(Console.ReadLine());
            x = (x * 1.8) + 32;
            Console.WriteLine("O valor em Farh é {0} °F", x);
            Console.ReadLine();




            
        }
    }
}