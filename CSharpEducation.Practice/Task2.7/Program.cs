﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.
            //a.строка и символ указываются программно
            string s = " jf*vn*h bvkj *vnvinr* iu*";
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*') k++;
            }
            Console.WriteLine("число '*' в строке равно " + k);
            //b.строка и символ указываются пользователем в консоли
            Console.WriteLine("введите строку");
            string s2 = Console.ReadLine();
            Console.WriteLine("введите символ");
            char c = Convert.ToChar(Console.ReadLine());
            int k2 = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (s2[i] == c) k2++;
            }
            Console.WriteLine("число данного символа в строке равно " + k2);
            //c.строка и символ указываются через аргументы командной строки?????
            Console.ReadKey();
        }
    }
}
