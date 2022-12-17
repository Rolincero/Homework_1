using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Excersise_4
    {
        public static void FindMaxOfThree()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] ints = {a, b, c};
            Console.WriteLine($"{ints.Max()} is max");
        }
    }
}
