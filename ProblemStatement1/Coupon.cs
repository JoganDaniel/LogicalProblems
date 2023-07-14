using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class Coupon
    {
        public void GetCoupon()
        {
            int length = 36;
            Random random = new Random();
            char[] randomValues = "qwertyuiopasdfghjklzxcvbnm1234567890".ToCharArray();
            Console.WriteLine("Enter number of characters ");
            int input = Convert.ToInt32(Console.ReadLine());
            string result = "";
            while (input > 0)
            {
                int r = random.Next(0, length);
                result += randomValues[r];
                input--;
            }
            Console.WriteLine(result);

        }
    }
}
