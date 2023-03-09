using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome , endereco,telefone;
       Console.WriteLine("declare seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("declare seu endereco?");
            endereco = Console.ReadLine();
            Console.WriteLine("declare seu telefone?");
            telefone = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"nome: {nome}\nEndereço:{endereco}\ntelefone:{telefone}");
        Console.ReadKey();
        }


    }
}
