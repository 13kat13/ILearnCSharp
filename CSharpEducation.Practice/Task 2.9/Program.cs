using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составить алгоритм увеличения всех трех, введенных с клавиатуры, переменных на 5,если среди
            //них есть хотя бы две равные. В противном случае выдать ответ «равных нет».
            Console.WriteLine("введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите третье число");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == b || b == c || a == c)
                Console.WriteLine($"{a + 5}; {b + 5}; {c + 5}");
            else Console.WriteLine("равных нет");
            Console.ReadKey();
        }
    }
}
