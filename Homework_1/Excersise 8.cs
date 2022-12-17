using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Excersise_8
    {
        public static void OddOfArray()
        {
            Console.Clear();
            Console.WriteLine("Программа выдачи ряда четных чисел до значения.");
            Console.Write("Введите число: ");

            int input = int.Parse(Console.ReadLine());

            for (int counter = 0; counter <= input; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.Write(counter + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Выполнение программы завершено.");
        }
    }
}
