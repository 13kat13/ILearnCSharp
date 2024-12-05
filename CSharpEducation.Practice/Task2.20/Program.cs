using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._20
{
    internal class Program
    {
        //Создайте перечисление (enum) для дней недели. Напишите программу, которая выводит на экран дни
        //недели по названиям
        enum DN
        {
            понедельник,
            вторник,
            среда,
            четверг,
            пятница,
            суббота,
            воскресение
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DN.воскресение);
            Console.WriteLine(DN.вторник);
            Console.WriteLine(DN.понедельник);
            Console.WriteLine(DN.пятница);
            Console.WriteLine(DN.среда);
            Console.WriteLine(DN.суббота);
            Console.WriteLine(DN.четверг);
            Console.ReadKey();

        }
    }
}
