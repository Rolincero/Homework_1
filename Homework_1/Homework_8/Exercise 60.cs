using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_8
{
    internal class Exercise_60
    {
        public static void ThrdDimArrGen()
        {
            Random random = new Random();
            int[,,] array = new int[2, 2, 2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = random.Next(10, 100);
                        Console.Write($"{array[i, j, k]}({i},{j},{k})");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
