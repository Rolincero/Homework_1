using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_2
{
    internal class Exercise_13
    {
        public static void PosThreeInDig()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (input.Length >= 3)
            {
                char[] dig_mas = new char[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    dig_mas[i] = input[i];
                }
                Console.WriteLine("Третий знак числа: " + dig_mas[2]);
            }
            else if (input.Length < 3)
            {
                Console.WriteLine("Третьего знака нет!");
            }

            Console.WriteLine("Для продолжения нажмите любую клавишу...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
