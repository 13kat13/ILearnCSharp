using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Известны два катета - найти гипотенузу
            Console.WriteLine("введите первый катет");
            double catheter1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите второй катет");
            double catheter2 = Convert.ToDouble(Console.ReadLine());
            double hypotenuse = Math.Sqrt(catheter1 * catheter1 + Math.Pow(catheter2, 2));
            Console.WriteLine("гипотенуза "+hypotenuse);
            //Известен один катет и гипотенуза - найти второй катет
            Console.WriteLine("введите катет");
            catheter1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите гипотенузу");
            hypotenuse = Convert.ToDouble(Console.ReadLine());
            catheter2 = Math.Sqrt(hypotenuse * hypotenuse - Math.Pow(catheter1, 2));
            Console.WriteLine("второй катет "+catheter2);
            Console.ReadKey();
        }
    }
}
