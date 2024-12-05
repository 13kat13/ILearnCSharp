using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создайте двумерный массив целых чисел произвольной длины и заполните случайными числами от 1 до 100.
            //Выведите на экран разницу максимального и минимального значений в каждой строке массива.
            Random rnd = new Random();
            int[][] ar = new int[rnd.Next(30)][];
            for (int i = 0; i < ar.Length; i++)//создается массив
            {
                ar[i] = new int[rnd.Next(1,30)];
                for (int j = 0; j < ar[i].Length; j++)
                    ar[i][j] = rnd.Next(100);
            }
            for (int i = 0; i < ar.Length; i++)//массив выводится на экран
            {
                for (int j = 0; j < ar[i].Length; j++)
                    Console.Write(ar[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < ar.Length; i++)//выводится разница элементов в одной строке
                Console.WriteLine(ar[i].Max<int>() - ar[i].Min<int>());
            Console.ReadKey();
        }
    }
}
