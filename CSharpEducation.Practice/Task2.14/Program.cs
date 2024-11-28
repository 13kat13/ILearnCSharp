using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._14
{
    internal class Program
    {
        //Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры массива передавайте
        //через аргументы метода.Также напишите отдельный метод для вывода двумерного массива в виде
        //матрицы на экран консоли. Массив заполните случайными числами.

        static int[,] CreateArray(int a, int b)
        {
            Random rnd = new Random();
            int[,] array = new int[a,b];
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                {
                    array[i,j] = rnd.Next(100);
                }
                    
            return array;
        }
        static void Vivod(int a, int b,int[,] array)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                    Console.Write(array[i,j] + " ");
                Console.WriteLine();
            }
                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] matr =CreateArray(a,b);
            Vivod(a,b,matr);
            Console.ReadKey();
        }
    }
}
