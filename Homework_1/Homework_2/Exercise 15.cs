using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_2
{
    internal class Exercise_15
    {
        public static void WhatDayToday()
        {
            int input = int.Parse(Console.ReadLine());

            if (input > 0 & input < 8)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Нет");
                        break;
                    case 2:
                        Console.WriteLine("Нет");
                        break;
                    case 3:
                        Console.WriteLine("Нет");
                        break;
                    case 4:
                        Console.WriteLine("Нет");
                        break;
                    case 5:
                        Console.WriteLine("Нет");
                        break;
                    case 6:
                        Console.WriteLine("Да");
                        break;
                    case 7:
                        Console.WriteLine("Да");
                        break;
                }
            }
            else Console.WriteLine("Нет такого дня.");
        }
    }
}
