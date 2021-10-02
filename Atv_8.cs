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
            double horatr, salminimo, valorhoratr, salbruto, imp, recebe;
            Console.WriteLine("Digite as horas trabalhadas");
            horatr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do salario minimo");
            salminimo = Convert.ToDouble(Console.ReadLine());

            valorhoratr = salminimo / 2;
            salbruto = horatr * valorhoratr;
            imp = salbruto * 0.03;
            recebe = salbruto - imp;

            Console.WriteLine("O seu salario a ser recebido é: R${0}",recebe);

            Console.ReadKey();
        }
    }
}
