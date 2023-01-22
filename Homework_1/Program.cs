using Homework_1.Homework_2;
using Homework_1.Homework_3;
using Homework_1.Homework_4;
using Homework_1.Homework_5;
using Homework_1.Homework_6;
using Homework_1.Homework_7;
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
            int[,] array = Exercise_47.SDimArray(m, n);

            Console.WriteLine("Введите координату 'm': ");
            m = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Введите координату 'n': ");
            n = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Элемент найден: {Exercise_50.FindInSArray(array, m, n)}");
        }
    }
}
