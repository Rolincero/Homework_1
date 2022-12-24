using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Homework_3
{
    internal class Exercise_19
    {
        public static string PolinomNum(long number)
        {
            if (number.ToString().Length != 5) return "Число не пятизначное";

            char[] check = number.ToString().ToCharArray();
            Array.Reverse(check);
            string result = new string(check);

            if (result == number.ToString())
            {
                return "Да";
            }
            else return "Нет";
        }
    }
}
