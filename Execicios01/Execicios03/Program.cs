using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicios03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nt1, nt2, nt3, nt4,nt5,media;
            Console.Write("declare a primeira idade ");
            nt1 = int.Parse(Console.ReadLine());
            Console.Write("declare a primeira idade ");
            nt2 = int.Parse(Console.ReadLine());
            Console.Write("declare a primeira idade ");
            nt3 = int.Parse(Console.ReadLine());
            Console.Write("declare a primeira idade ");
            nt4 = int.Parse(Console.ReadLine());
            Console.Write("declare a primeira idade ");
            nt5 = int.Parse(Console.ReadLine());
            media= (nt1+nt2+nt3+nt4+nt5) /5;
            Console.Clear();
            Console.WriteLine($"o resultada da media e : {media}");
            Console.ReadKey();
        }
    }
}
