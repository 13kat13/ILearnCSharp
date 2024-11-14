using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi= 3.1415926535;
            double radius = 3;
            double s=pi*radius*radius;
            Console.WriteLine("Площадь круга с радиусом "+radius+" равна "+s);
            Console.ReadKey();
        }
    }
}
