using Homework_1.Homework_2;
using Homework_1.Homework_3;
using Homework_1.Homework_4;
using Homework_1.Homework_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine()); // Задаем длинну массива
            Console.WriteLine($"\n{Exercise_38.DiffMaxMinInArray(input)}");
        }
    }
}
