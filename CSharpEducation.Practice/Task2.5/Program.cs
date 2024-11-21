using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
            //треугольника можно было задавать программно.Пример:
            //a. *
            //**
            //***
            //****
            //и тд
            Console.WriteLine("введите высоту елочки:");
            int v = Convert.ToInt32(Console.ReadLine());
            string s = "";
            for(int i = 0; i < v; i++)
            {
                s += "*";
                Console.WriteLine(s);
            }
            //b. *
            //**
            //***
            //****
            //и тд
            Console.WriteLine("введите высоту елочки:");
            int v2 = Convert.ToInt32(Console.ReadLine());
            string s2;
            for (int i = 1; i < v2+1; i++)
            {
                s2 = "";
                for (int j = 0; j < v2-i; j++)
                {
                    s2 += " ";
                }
                for (int j = 0; j < i; j++)
                {
                    s2 += "*";
                }
                Console.WriteLine(s2);
            }
            //c.Дайте возможность задавать символ для отрисовки программно.Т.е.
            //вместо звёздочки может быть любой символ.
            Console.WriteLine("введите высоту елочки:");
            int v3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите из чего будет нарисованна елочка:");
            string s3 = Console.ReadLine();
            string str = "";
            for (int i = 0; i < v3; i++)
            {
                str += s3;
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
