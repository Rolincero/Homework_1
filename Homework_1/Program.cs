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
            Console.WriteLine("Введите диапазон: ");
            Console.Write("От: ");
            int inp1 = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int inp2 = int.Parse(Console.ReadLine());
            int cntr = 0;
            Console.Clear();

            Console.WriteLine($"Сумма диапазона: {Exercise_66.SumOfRange(inp1, inp2, ref cntr)}");
            Console.ReadKey();
        }
    }
}
