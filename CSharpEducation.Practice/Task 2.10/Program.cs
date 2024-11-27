using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._10
{
    internal class Program
    {
        //Напишите метод, который создаёт массив целых чисел и возвращает его. Размер массива нужно
        //передавать в качестве аргумента. Вдобавок напишите метод, который выводит переданный массив на экран консоли
        static int[] CreateArray(int a)
        {
            int[] array = new int[a];
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = i+1;
            }
            return array;
        }
        static void Vivod(int[] array)
        {
            for(int i = 0;i<array.Length;i++)
                Console.Write(array[i]+" ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите размер массива");
            int raz=Convert.ToInt32(Console.ReadLine());
            int[] matr=CreateArray(raz);
            Vivod(matr);
            Console.ReadKey();
        }
    }
}
