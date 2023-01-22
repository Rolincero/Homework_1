using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_1
{
    internal class Seminar_2
    {
        public static int GetNumber(int input)
        {
            int result = 0;

            while (true) 
            {
                Console.WriteLine(input);

                if (int.TryParse(Console.ReadLine(), out result))
                {
                    break;
                }
                else Console.WriteLine("Ввели не число.");
            }

            return result;
        }

        // Генерирует число от leftBoard до rightBoard
        public static int RandomNumber(int leftBoard, int rightBoard)
        {
            Random rnd = new Random();
            int result = rnd.Next(leftBoard, rightBoard + 1);
            return result;
        }

        public static void Exercise_1()
        {
            // Напишите программу, которая будет принимать на вход два числа
            // и выводить, является ли второе число кратным первому.
            // Если число 2 не кратно числу 1, то программа выводит остаток от деления.

            int mainDigit = int.Parse(Console.ReadLine());
            int divideDigit = int.Parse(Console.ReadLine());

            if (mainDigit % divideDigit == 0)
            {
                Console.WriteLine("Числа кратны");
            }
            else
            {
                Console.WriteLine($"Число не кратно, остаток {mainDigit % divideDigit}");
            }
        }

        public static void Exercise_2()
        {
            // Напишите программу, которая принимает на вход число и проверяет,
            // кратно ли оно 7 и 23.

            int input = int.Parse(Console.ReadLine());

            if (input % 7 == 0 & input % 23 == 0)
            {
                Console.WriteLine("Да");
            }
            else Console.WriteLine("Нет");
        }

        public static void Exercise_3()
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
