using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите игру Угадай число. Программа случайно генерирует число от 1 до 100, а пользователь
            //пытается угадать это число. При успешной догадке выводите поздравление пользователя. Также покажите
            //количество попыток, принятых пользователем.

            Random rnd = new Random();
            Console.WriteLine("ИГРА УГАДАЙ ЧИСЛО\nв какую игру ты хочешь сыграть?\n" +
                "1. ограничение по попыткам. я дам тебе 10 попыток угадать число которое я загадал\n" +
                "2. с подсказками. у тебя также будет 10 попыток, но я так же буду подсказывать.");
            int v;
            int yg;
            int game =Convert.ToInt32(Console.ReadLine());
            bool res=false;
            
               
            //a.Сделайте ограничение по попыткам. Например, если попыток больше 10, то пользователь проиграл
            if (game == 1)
            {
                Console.WriteLine("у тебя есть 10 попыток и нет подсказок\nначинай");
                yg = rnd.Next(1, 100);
                for (int i = 0; i < 10; i++)
                {
                    res = false;
                    v = Convert.ToInt32(Console.ReadLine());
                    if (v == yg) { Console.WriteLine("ПОЗДРАВЛЯЮ! ТЫ УГАДАЛ!"); break; }
                    else
                    {
                        Console.WriteLine("Пф-ф-ф, лузер! у тебя осталось еще ~" + (10-i-1) + "~ попыток"); 
                        res = true;
                    }
                }
                if (res)
                    Console.WriteLine("Блин, ну ты и лошок! я загадал число " + yg);
            }
            //b.Сделайте подсказки для пользователя. Если предположенное число больше загаданного, то писать в консоль об
            //этом. Аналогично и для меньшего числа.
            else if (game == 2)
            {
                Console.WriteLine("у тебя есть 10 попыток и подсказки\nначинай");
                yg = rnd.Next(1, 100);
                for (int i = 0; i < 10; i++)
                {
                    res = false;
                    v = Convert.ToInt32(Console.ReadLine());
                    if (v == yg) {Console.WriteLine("ПОЗДРАВЛЯЮ! ТЫ УГАДАЛ!"); break; }
                    else
                    {
                        if (v < yg) Console.WriteLine("пхах, твое число меньше моего!");
                        else if (v > yg) Console.WriteLine("ххпапхахахап, твое число больше моего!");
                        Console.WriteLine("у тебя осталось еще ~" + (10 - i-1) + "~ попыток");
                        
                        res = true;
                    }
                }
                if (res)
                    Console.WriteLine("Блин, ну ты и лошок! я загадал число " + yg);
            }
            Console.ReadKey();
        }
    }
}
