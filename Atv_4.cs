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




                const double consta = Math.PI;
                double vraio, rsempi, rcompi;
                Console.WriteLine("Calculo da Área do círculo");
                Console.WriteLine("Digite o raio do círculo");
                vraio = Convert.ToDouble(Console.ReadLine());
                rcompi = Math.Pow(vraio, 2);
                rsempi = consta * rcompi;
                rsempi = Math.Round(rsempi, 2);
                Console.WriteLine("O valor da Área é: PI * {0}", rcompi);
                Console.WriteLine("O valor multiplicando com PI é: {0}", rsempi);
                Console.ReadKey();

            
        }
    }
}
