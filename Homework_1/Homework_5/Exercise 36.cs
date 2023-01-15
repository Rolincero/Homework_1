using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_5
{
    internal class Exercise_36
    {
        public static int OddSumArray(int input)
        {
            var rnd = new Random(); // Подключаем метод Random
            double[] array = new double[input];

            // Заполняем массив рандом числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }

            // Выводим в консоль массив для проверки
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // Ищем числа на нечетных позициях и складываем их
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0) 
                {
                    result += (int)array[i];
                }
            }

            return result;
        }
    }
}
