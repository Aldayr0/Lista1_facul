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

            int alt, deseja, talves;
            Console.WriteLine("Digite a altura do degrau em cm:");
            alt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o quanto em cm deseja subir");
            deseja = Convert.ToInt32(Console.ReadLine());
            talves =  deseja/alt;
            Console.WriteLine("O quanto você subiu: {0}", talves);

            Console.ReadKey();

        }
    }
}

