using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив строк, который заполняется пользователем
            //через консоль. Затем этот массив должен быть выведен на экран консоли.
            Console.WriteLine("введите количество строк:");
            int k = Convert.ToInt32(Console.ReadLine());
            string[] s = new string[k];
            Console.WriteLine("введите строки:");
            for(int i = 0; i < k; i++)
            {
                s[i] = Console.ReadLine();
            }
            for (int i = 0; i < s.Length; i++)
                Console.Write(s[i] + " ");
            Console.ReadKey();
        }
    }
}
