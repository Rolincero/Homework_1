using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_4
{
    internal class Exercise_25
    {
        public static int Degree(int input, int degree)
        {
            int result = input;

            for (int i = 1; i < degree; i++)
            {
                result = result * input;
            }
            return result;
        }
    }
}
