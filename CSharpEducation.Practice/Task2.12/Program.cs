using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, в которой создаётся массив и выводится на экран консоли.Размер массива
            //передавайте в качестве первого аргумента командной строки.Число, которым будет заполняться
            //массив передайте через второй аргумент командной строки.
            int[] array = new int[Convert.ToInt32(args[0])];
            int a = Convert.ToInt32(args[1]);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

        }
    }
}
