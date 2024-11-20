using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a.цикл for. Пусть он выводит в консоль значение своего же счётчика.
            for (int i = 0; i < 5; i++)
                Console.WriteLine(i);
            //b.цикл while.Пусть он выводит в консоль значение своего же счётчика.
            int j = 5;
            while(j < 10)
            {
                Console.WriteLine(j);
                j++;
            }
            //c.цикл do while.Пусть он выводит в консоль значение своего же счётчика.
            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            }while(k < 15);
            //d.цикл for, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.
            string[] s = new string[5];
            Console.WriteLine("введите пять слов через enter");
            for (int i = 0;i < s.Length;i++)
                s[i]=Console.ReadLine();
            Console.WriteLine($"{s[0]} {s[1]} {s[2]} {s[3]} {s[4]}");
            //e.цикл while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.
            string ss="";
            Console.WriteLine("введите пять слов через enter");
            for (int i = 0; i < 5; i++)
                ss += Console.ReadLine()+" ";
            Console.WriteLine(ss);
            //f.цикл do while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.
            ss = "";
            Console.WriteLine("введите пять слов через enter");
            int l = 5;
            do {
                ss += Console.ReadLine() + " ";
                l--;
            } while(l>0);
            Console.WriteLine(ss);
            Console.ReadKey();
        }
    }
}
