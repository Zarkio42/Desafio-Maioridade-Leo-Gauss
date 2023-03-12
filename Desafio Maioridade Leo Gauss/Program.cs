using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Maioridade_Leo_Gauss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você não é maior de idade." + " Ainda faltam " + (18 - idade) + " anos para atingir a maioridade penal.");
                Console.ReadKey();
            }
        }
    }
}
