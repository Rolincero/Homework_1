using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_7
{
    public static class Exercise_52
    {
        public static double[] ColMidSum(int[,] array)
        {
            double[] midSum = new double[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0) ; i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    midSum[j] += ((double)array[i, j] / array.GetLength(0));
                }
            }

            return midSum;
        }
    }
}
