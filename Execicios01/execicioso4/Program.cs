using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execicioso4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largura, altura, profundidade, caixa;
            Console.Write("declare a largura da caixa retangular ");
            largura = int.Parse(Console.ReadLine());
            Console.Write("declare a altura da caixa retangular ");
            altura = int.Parse(Console.ReadLine());
            Console.Write("declare a profundidade da caixa retangular ");
            profundidade = int.Parse(Console.ReadLine());
            caixa = (largura*altura*profundidade);
            Console.Clear();
            Console.WriteLine($"o volume da caixa e : {caixa}");
            Console.ReadKey();
        }
    }
}
