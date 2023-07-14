using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class Prime
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Enter the nummber");
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
            if (n > 1)
            {
                Console.WriteLine(1);
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    c = 0;
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 2)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
