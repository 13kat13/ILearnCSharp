using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу для сравнения двух целых чисел. Ввод осуществляйте через консоль.
            Console.WriteLine("введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == b) Console.WriteLine("числа равны");
            else if (a > b) Console.WriteLine("первое число больше второго");
            else Console.WriteLine("второе число больше первого");
            Console.ReadKey();
        }
    }
}
