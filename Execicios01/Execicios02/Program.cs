using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num1,num2,valor;
            Console.WriteLine("declare o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("declare o segundo numero");
            num2 = int.Parse(Console.ReadLine());
            valor = num1 * num2;
            Console.WriteLine(valor);


        }
    }
}
