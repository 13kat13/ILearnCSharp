using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив и выводится на экран консоли. Размер массива передавайте
            //в качестве первого аргумента командной строки.
            int[] array = new int[Convert.ToInt32(args[0])];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
