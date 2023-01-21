using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_6
{
    internal class Exercise_43
    {
        public static void FindCrossVector(double b1, double k1, double b2, double k2, ref double x, ref double y)
        {
            x = (-b2 + b1) / (-k1 + k2);
            y = k2 * x + b2;
        }
    }
}
