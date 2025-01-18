using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal class Maths
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static string Divide(double a, double b)
        {
            if (b == 0)
                return "Can not be divided by 0 ";
            else
                return (a / b).ToString();
        }



    }
}
