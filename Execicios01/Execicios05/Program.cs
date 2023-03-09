using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litros, km , consumo;
            Console.Write("declare a quantidade de litros ");
            litros = int.Parse(Console.ReadLine());
            Console.Write("declare a quantidade de km percorrido ");
            km = int.Parse(Console.ReadLine());
            consumo = km / litros;
            Console.Clear();
            Console.WriteLine($" se consumo de combustuvel e de: {consumo} litro por km");
            Console.ReadKey();
        }
    }
}
