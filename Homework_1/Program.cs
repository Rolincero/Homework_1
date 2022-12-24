using Homework_1.Homework_2;
using Homework_1.Homework_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main()
        {
            double A1 = double.Parse(Console.ReadLine());
            double A2 = double.Parse(Console.ReadLine());
            double A3 = double.Parse(Console.ReadLine());
            double B1 = double.Parse(Console.ReadLine());
            double B2 = double.Parse(Console.ReadLine());
            double B3 = double.Parse(Console.ReadLine());
            Console.WriteLine(Exercise_21.ThirdDimDist(A1,A2,A3,B1,B2,B3));
        }
    }
}
