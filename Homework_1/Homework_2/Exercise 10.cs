using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_2
{
    internal class Exercise_10
    {
        public static void CenterOfDigit()
        {
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine();

            if (input.Length == 3)
            {
                char[] dig_mas = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    dig_mas[i] = input[i];
                }
                Console.WriteLine("Второе число: " + dig_mas[1]);
            }
            else Console.WriteLine("Число неверного формата.");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
