using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение параметра x:");
            string S = Console.ReadLine();
            double x = Convert.ToDouble(S);
            double F = (Math.Sin(x) - 2 * Math.Cos(x));
            Console.WriteLine($"Для значений x = {x}, F = {F}.");
        }
    }
}
