using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_1.Homework_5
{
    internal class Exercise_34
    {
        public static int FindEvenInRndArray(int input)
        {
            var rnd = new Random(); // Подключаем метод Random
            double[] array = new double[input];

            // Заполняем массив рандом числами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 1000);
            }

            // Выводим в консоль массив для проверки
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            // Проверяем элементы массива на четность
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] % 2 == 0) result++;
            }

            return result;
        }
    }
}
