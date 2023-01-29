using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_9
{
    internal class Exercise_64
    {
        public static int NumRowButReversed(int inp)
        {
            if (inp == 0) return 1;
            else Console.Write(inp-- + " ");
            NumRowButReversed(inp);
            return -1;
        }
    }
}
