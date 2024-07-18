﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project_2
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
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Can Not Divided By Zero");
            }
            return a / b;
        }
    }
}
