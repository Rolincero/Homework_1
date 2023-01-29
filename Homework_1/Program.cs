using Homework_1.Homework_9;
using Microsoft.Win32;
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
            int inp = int.Parse(Console.ReadLine());
            Console.Clear();
            Exercise_64.NumRowButReversed(inp);
            Console.ReadKey();
        }
    }
}
