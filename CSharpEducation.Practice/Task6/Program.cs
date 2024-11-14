using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Известны два катета - найти гипотенузу
            double catheter1 = 3;
            double catheter2 = 4;
            double hypotenuse = Math.Sqrt(catheter1 * catheter1 + Math.Pow(catheter2, 2));
            Console.WriteLine(hypotenuse);
            //Известен один катет и гипотенуза - найти второй катет
            catheter1 = 3;
            hypotenuse = 5;
            catheter2 = Math.Sqrt(hypotenuse * hypotenuse - Math.Pow(catheter1, 2));
            Console.WriteLine(catheter2);
            Console.ReadKey();
        }
    }
}
