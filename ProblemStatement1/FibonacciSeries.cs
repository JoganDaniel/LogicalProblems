﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            Console.Write("Enter the number of elements: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            for (int i = 2; i < l; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
