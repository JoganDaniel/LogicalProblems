using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class Perfect
    {
        public void CheckPerfect()
        {
            int s = 0;
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    s += i;
                }
            }
            if (s == n)
            {
                Console.WriteLine("It is a perfect number");
            }
            else
            {
                Console.WriteLine("Not perfect");
            }
        }
    }
}
