using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_4
{
    internal class Exercise_27
    {
        public static int Numerology(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                result += int.Parse(input[i].ToString());
            }
            return result;
        }
    }
}
