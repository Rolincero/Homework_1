using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public static class Seminar_6
    {
        public static void ReverseArray(int[] array)
        {
            int[] result = new int[array.Length];
            int count = 0;
            for (int i = array.Length - 1; i >= 0; i++)
            {
                result[count] = array[i];
                count++;
            }
        }

        public static int[] InitArray(int dimension)
        {
            int[] array = new int[dimension];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next();
            }

            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public static string BinaryNum(int input) => Convert.ToString(input, 2);
    }
}
