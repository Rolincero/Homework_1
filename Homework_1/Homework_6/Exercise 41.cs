using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_6
{
    internal class Exercise_41
    {
        public static int Counter(string input)
        {
            int[] array = input.Split(',').Select(p => Convert.ToInt32(p)).ToArray();
            return Array.FindAll(array, i => i > 0).Count();
        }
    }
}
