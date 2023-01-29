using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_9
{
    internal class Exercise_66
    {
        public static int SumOfRange(int inp1, int inp2, ref int cntr)
        {
            int temp = 0;
            if (inp1 > inp2) 
            {
                temp = inp1;
                inp1 = inp2;
                inp2 = temp;
            }
            cntr += inp1;

            if (inp1 == inp2) return cntr;
            else SumOfRange(inp1 + 1, inp2, ref cntr);
            return cntr;
        }
    }
}
