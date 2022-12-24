using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_3
{
    internal class Exercise_23
    {
        public static void CubePow(int input)
        {
            for (double i = 0; i <= input; i++)
            {
                Console.Write($"{Math.Pow(i, 3)}, ");
            }
            Console.WriteLine("\n");
        }
    }
}
