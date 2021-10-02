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
            Console.WriteLine("Vamos ver sua idade em 2022");

            Console.WriteLine("Digite seu ano de nascimento");
            int anoN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano atual");
            int anoA = Convert.ToInt32(Console.ReadLine());
            int idade = anoA - anoN;
            int idadenofuturokk = 2022 - anoN;
            Console.WriteLine("------------");
            Console.WriteLine("Sua idade atual é: {0} Anos", idade);
            Console.WriteLine("Sua idade em 2022 é: {0} Anos", idadenofuturokk);
            Console.ReadKey();
            




        }
    }
}
