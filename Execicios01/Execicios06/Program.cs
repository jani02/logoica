using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ano, meses, dias, semana;
            Console.Write("declare uma quantidade de dias ");
            dias = int.Parse(Console.ReadLine());
            Console.Write("declare uma ");
            semana = dias / 7;
             ano = dias / 365;
            meses = dias / 30;
            Console.Clear();
            Console.WriteLine($" sao:{semana} semanas,{meses} meses,{ano} anos");
            Console.ReadKey();
        }
    }
}
