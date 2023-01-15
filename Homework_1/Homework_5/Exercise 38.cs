using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_5
{
    internal class Exercise_38
    {
        public static double DiffMaxMinInArray(int input)
        {
            var rnd = new Random(); // Подключаем метод Random
            double[] array = new double[input];

            // Заполняем массив рандом числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-1000000, 1000000) + rnd.NextDouble(); // Целая часть + дробная
            }

            // Выводим в консоль массив для проверки
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            return array.Max() - array.Min();
        }
    }
}
