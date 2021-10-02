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
            double x;
            Console.WriteLine("Escreva um numero positivo ou negativo: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x >= 0) 
            {
                x = Math.Sqrt(x);
                Console.WriteLine("A Raiz quadrada é: {0}", x);
            }
            else
            {
                x = Math.Pow(x, 2);
                Console.WriteLine("O valor Elevado a 2 é: {0}", x);
            }
            Console.ReadKey();
        }








    }
}
