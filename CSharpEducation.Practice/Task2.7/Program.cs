using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
            k = k * 100 / s.Length;
            Console.WriteLine("процент вхождения заданного символа '*' в строку равен " + k + "%");
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
            k2 = k2 * 100 / s2.Length;
            Console.WriteLine("процент вхождения заданного символа '" + c + "' в строку равен " + k2 + "%");
            Console.ReadKey();
            //c.строка и символ указываются через аргументы командной строки?????
            string s3 = args[0];
            char c3 = Convert.ToChar(args[1]);
            int k3 = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                if (s3[i] == c3) k3++;
            }
            k3 = k3 * 100 / s3.Length;
            Console.WriteLine("процент вхождения заданного символа '" + c3 + "' в строку равен " + k3 + "%");
            
        }
    }
}
