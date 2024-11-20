using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a.метры в километры
            Console.WriteLine("введите число в метрах");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(m/1000+" километров");
            //b.километры в сантиметры
            Console.WriteLine("введите число в километрах");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(km * 100000 + " сантиметров");
            //c.м / с в км/ ч
            Console.WriteLine("введите число в метрах в секунду");
            double mvs = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(mvs * 10/36 + " километров в час");
            //d.градусы C в градусы F
            Console.WriteLine("введите градусы в цельсиях");
            double с = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(с * 1.8+32 + " фаренгейта");
            Console.ReadKey();
        }
    }
}
