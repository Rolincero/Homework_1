using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_6
{
    internal class Exercise_41
    {
        public static int Counter(string[] input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (int.Parse(input[i]) > 0) result++;
            }

            return result;
        }
    }
}
