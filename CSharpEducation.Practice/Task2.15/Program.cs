using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте одномерный массив целых чисел произвольной длины и заполните случайными числами
            //от 1 до 100.Выведите на экран разницу максимального и минимального значений в нём.
            Random rnd = new Random();
            int[] ar = new int[rnd.Next(30)];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(100);
            }
            for (int j = 0; j < ar.Length; j++)
                Console.Write(ar[j] + " ");
            Console.WriteLine();
            Console.WriteLine(ar.Max<int>()-ar.Min<int>());
            Console.ReadKey();
        }
    }
}
