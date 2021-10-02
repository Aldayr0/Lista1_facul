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
            double carroreal;
            Console.WriteLine("Calculo do carro para o consumidor");

            Console.WriteLine("Digite o preço de fabrica");
            double carrof = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o percentual de lucro do distribuidor");
            double lucrod = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o percentual de imposto");
            double imp = Convert.ToDouble(Console.ReadLine());

            lucrod = carrof * (lucrod / 100);
            imp = carrof * (imp / 100);
            carroreal = carrof + imp + lucrod;

            Console.WriteLine("------------");
            Console.WriteLine("Lucro do Distribuidor : R${0}",lucrod);
            Console.WriteLine("Valor do imposto : R${0}", imp);
            Console.WriteLine("O preço do carro para o consumidor : R${0}", carroreal);
            Console.ReadKey();











        }
    }
}
