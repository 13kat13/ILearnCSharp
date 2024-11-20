using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a + b). Все переменные задаются пользователем. Учтите деление на 0.
            Console.WriteLine("формула (а + b — f / а) + f * a * a — (a + b)\nвведите a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите f:");
            double f = Convert.ToDouble(Console.ReadLine());
            if(a!=0)
            {
                Console.WriteLine(Convert.ToString((a + b - f / a) + f * a * a - (a + b)));
            }
            else
                Console.WriteLine("делить на ноль нельзя");
            Console.ReadKey();
        }
    }
}
