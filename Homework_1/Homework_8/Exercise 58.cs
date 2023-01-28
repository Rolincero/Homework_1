using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_8
{
    internal class Exercise_58
    {
        public static int[,] MatrxMul(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(0),array2.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(1); k++)
                    {
                        result[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }
            return result;
        }
    }
}
