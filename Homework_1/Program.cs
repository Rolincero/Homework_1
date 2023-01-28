using Homework_1.Homework_7;
using Homework_1.Homework_8;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите высоту массива 'm': ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину массива 'n': ");
            int n = int.Parse(Console.ReadLine());

            int[,] array1 = Exercise_47.SDimArray(2, 2);
            int[,] array2 = Exercise_47.SDimArray(2, 2);
            int[,] result = Exercise_58.MatrxMul(array1, array2);

            // Вывод массива в консоль для проверки
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write($"{result[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
