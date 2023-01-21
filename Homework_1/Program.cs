using Homework_1.Homework_2;
using Homework_1.Homework_3;
using Homework_1.Homework_4;
using Homework_1.Homework_5;
using Homework_1.Homework_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите числа через запятую, без пробелов. \nПример: 1,2,3,4 \n");
            string input = Console.ReadLine();
            var array = input.Split(',');
            Console.WriteLine($"Чисел больше нуля: {Exercise_41.Counter(array)}");
        }
    }
}
