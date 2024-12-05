using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._21
{
    internal class Program
    {
        //Создайте перечисление (enum) для дней недели. Напишите программу, которая считывает ввод пользователя
        //и в зависимости от его ввода(число от 1 до 7) будет выводиться на экран консоли соответствующий день недели.
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
            int a=Convert.ToInt32(Console.ReadLine())-1;
            if (a == 6)
                Console.WriteLine(DN.воскресение);
            if (a == 1)
                Console.WriteLine(DN.вторник);
            if(a==0)
            Console.WriteLine(DN.понедельник);
            if (a == 4)
                Console.WriteLine(DN.пятница);
            if (a == 2)
                Console.WriteLine(DN.среда);
            if (a == 5)
                Console.WriteLine(DN.суббота);
            if (a == 3)
                Console.WriteLine(DN.четверг);
            Console.ReadKey();

        }
    }
}
