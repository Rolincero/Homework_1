using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_3
{
    internal class Addition
    {
        // Метод перебора чисел и для вывода в консоль результата.
        public static void SimpleNumArray(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                if (isSimple(i))
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine("");
        }

        // Метод проверки числа на простоту... простату...:)
        private static bool isSimple(int N)
        {
            for (int i = 2; i <= (N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }
}
