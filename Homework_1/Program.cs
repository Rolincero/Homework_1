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

            Exercise_60.ThrdDimArrGen();
        }
    }
}
