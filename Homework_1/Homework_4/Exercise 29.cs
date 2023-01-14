using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_4
{

    internal class Exercise_29
    {
        public static dynamic SplitArray(string input)
        {
            var array = input.Split(',');
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = int.Parse(array[i]);
            }
            return result;
        }
    }
}