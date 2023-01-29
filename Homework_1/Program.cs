using Homework_1.Homework_9;
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
            Console.Write("Введите первое число: ");
            int in1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int in2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {Exercise_68.AkkFun(in1, in2)}");
            Console.ReadKey();
        }
    }
}
