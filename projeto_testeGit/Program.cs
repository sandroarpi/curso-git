using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_testeGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Você está bem?");
            string resp = Console.ReadLine();
            if (resp == "sim")
            {
                Console.WriteLine("Que bom!");
            }
            else
            {
                Console.WriteLine("O que houve?");
            }
            Console.ReadLine();
        }
    }
}
