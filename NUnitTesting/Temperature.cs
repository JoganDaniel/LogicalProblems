using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class Temperature
    {
        public void ConvertTemp()
        {
            Console.WriteLine("1.C to F\n2.F to C");
            int ch = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter the temperature");
            double t = Convert.ToDouble(Console.ReadLine());
            double ans=0;
            if (ch == 1)
            {
                ans = (t * 9 / 5) + 32;
            }
            else if(ch == 2)
            {
                ans = (t - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Enter 1 or 2");
            }
            Console.WriteLine("Converted temperature is " + ans);
        }
    }
}
