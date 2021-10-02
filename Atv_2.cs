using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frame
{
    class Program
    {
        static void Main(string[] args)
        {
            double numaulas, vaulas, desconto, valorbruto, vdesconto;      
            Console.WriteLine("Calculo liquido do Salario de um Professor");

            Console.WriteLine("Digite o mumero de aulas");
            numaulas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada aula");
            vaulas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o desconto do INSS");
            desconto = Convert.ToDouble(Console.ReadLine());

            valorbruto = numaulas * vaulas;
            vdesconto = valorbruto - (valorbruto * (desconto / 100));

            Console.WriteLine("Salario Bruto é: R${0}", valorbruto);
            Console.WriteLine("Salario Liquido é: R${0}", vdesconto);

            Console.ReadKey();
        }







        
    }
}
