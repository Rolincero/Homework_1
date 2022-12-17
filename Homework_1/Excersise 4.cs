using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Excersise_4
    {
        public static void FindMaxOfThree()
        {
            Console.Clear();
            Console.WriteLine("Программа нахождения максимального из трех чисел.");
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());
            int[] ints = {a, b, c};
            Console.WriteLine($"{ints.Max()} максимальное.");
            Console.WriteLine("Для продолжения нажмите любую клавишу...");
        }
    }
}
