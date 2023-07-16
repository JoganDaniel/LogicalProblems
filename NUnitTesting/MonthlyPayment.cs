using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class MonthlyPayment
    {
        public void Payment()
        {
            Console.WriteLine("Enter Principal amount");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Years");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            int r = Convert.ToInt32(Console.ReadLine());
            double n = 12.0 * y;
            double num = p * r;
            double rate = r / 1200.0;
            double z =Math.Pow((1 + rate), n);
            double denom = 1.0-z;
            Console.WriteLine("Monthly Payment is : "+num/denom);
        }
    }
}
