using Homework_1.Homework_2;
using Homework_1.Homework_3;
using Homework_1.Homework_4;
using Homework_1.Homework_5;
using Homework_1.Homework_6;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Program
    {
        static void Main()
        {
            double x = 0;
            double y = 0;
            Console.Write("Введите значение b1: ");
            double b1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение k1: ");
            double k1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b2: ");
            double b2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение k2: ");
            double k2 = int.Parse(Console.ReadLine());
            Exercise_43.FindCrossVector(b1, b2, k1, k2, ref x, ref y);
            Console.WriteLine($"Линии пересекутся в точке [{Math.Round(x,2)} ; {Math.Round(y,2)}]");
        }
    }
}
