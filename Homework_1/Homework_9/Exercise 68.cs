using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_9
{
    internal class Exercise_68
    {
        public static int AkkFun(int in1, int in2)
        {
            if (in1 == 0)
            {
                return in2 + 1;
            }
            if (in1 > 0 && in2 == 0)
            {
                return AkkFun(in1 - 1, 1);
            }
            return AkkFun(in1 - 1, AkkFun(in1, in2 - 1));
        }
    }
}
