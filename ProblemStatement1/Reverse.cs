using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class Reverse
    {
        public void ReverseNum()
        {
            Console.WriteLine("Enter a num");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = 0, rev = 0;
            while (n > 0)
            {
                d = n % 10;
                rev = rev * 10 + d;
                n = n / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
