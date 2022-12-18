using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, которая принимает на вход два числа и
            // проверяет, является ли одно число квадратом другого.

            Console.Write("Введите первое число: ");
            int mainDig = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int secDig = int.Parse(Console.ReadLine());

            if (mainDig * mainDig == secDig)
            {
                Console.WriteLine("Да");
            }
            else Console.WriteLine("Нет");

        }
    }
}
