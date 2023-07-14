using ProblemStatement1;
using System;

namespace ProblemStatment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Fibonacci\n2.Perfect\n3.Prime\n4.Reverse\n5.Coupon\n6.Stopwatch\n7.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
                {
                    case 1:
                        FibonacciSeries fibonacci = new FibonacciSeries();
                        fibonacci.Fibonacci();
                        break;
                    case 2:
                        Perfect perfect = new Perfect();
                        perfect.CheckPerfect();
                        break;
                    case 3:
                        Prime prime = new Prime();
                        prime.PrimeFactors();
                        break;
                    case 4:
                        Reverse reverse = new Reverse();
                        reverse.ReverseNum();
                        break;
                    case 5:
                        Coupon coupon = new Coupon();
                        coupon.GetCoupon();
                        break;
                    case 6:
                        Stopwatch sw = new Stopwatch();
                        sw.RunStopwatch();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter a number from 1-4");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}