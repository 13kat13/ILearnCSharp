using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2._17
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Напишите игру Угадай число. Программа случайно генерирует число от 1 до 100, а пользователь
            //пытается угадать это число. При успешной догадке выводите поздравление пользователя.
            Random rnd = new Random();
            Console.WriteLine("ИГРА УГАДАЙ ЧИСЛО");
            int v=1;
            int yg;
            while (v != 0)
            {
                Console.WriteLine("чтобы выйти из игры введите 0,\n чтобы играть введите число от 1 до 100 которое я загадал");
                yg = rnd.Next(1, 100);
                v = Convert.ToInt32(Console.ReadLine());
                if (v == yg) Console.WriteLine("ПОЗДРАВЛЯЮ! ТЫ УГАДАЛ!");
                else Console.WriteLine("Пф-ф-ф, лузер! я загадал число " + yg);
            }

        }
    }
}
