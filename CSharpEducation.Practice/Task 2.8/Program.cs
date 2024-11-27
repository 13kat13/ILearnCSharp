using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task_2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая переводит строку в разные регистры
            //a.в верхний регистр: f->F
            Console.WriteLine("введите строку которую хотите перевести в верхний регистр");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1.ToUpper());
            //b.в нижний регистр: F->f
            Console.WriteLine("введите строку которую хотите перевести в нижний регистр");
            string s2 = Console.ReadLine();
            Console.WriteLine(s2.ToLower());
            //c.делает заглавную букву в слове: привет->Привет
            Console.WriteLine("введите строку которую хотите вывести с заклавной буквы");
            string s3 = Console.ReadLine();
            string sn =Convert.ToString(s3[0]);
            string sc= s3.Substring(1);
            Console.WriteLine(sn.ToUpper()+sc);
            Console.ReadKey();
        }
    }
}
