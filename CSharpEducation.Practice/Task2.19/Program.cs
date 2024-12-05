using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._19
{
    internal class Program
    {
        static void Main(string[] args)
            //Напишите программу для вычисления високосного года
        {
            int g=Convert.ToInt32(Console.ReadLine());
            if (g % 4 == 0)
                if (g % 100 == 0)
                    if (g % 400 == 0)
                        Console.WriteLine("год високосный");
                    else Console.WriteLine("год не високосный");
                else Console.WriteLine("год високосный");
            else Console.WriteLine("год не високосный");

            Console.ReadKey();
        }
    }
}
