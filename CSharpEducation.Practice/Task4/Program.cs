using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше отчество:");
            string namepatronymic = Console.ReadLine();
            Console.WriteLine(name + namepatronymic + ", приветствую Вас!");
            Console.ReadKey();
        }
    }
}
