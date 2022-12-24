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
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Exercise_19.PolinomNum(number));

        }
    }
}
