using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_3
{
    internal class Exercise_21
    {
        public static double ThirdDimDist(double A1, double A2, double A3, double B1, double B2, double B3) => Math.Sqrt(Math.Pow((A1 - B1), 2) + Math.Pow((A2 - B2), 2) + Math.Pow((A3 - B3), 2));
    }
}
