using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class DaysOfWeek
    {
        public static int FindDay(int month, int day, int year)
        {
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + 31 * m0 / 12) % 7;

            return d0;
        }

        public void Day()
        { 
            Console.WriteLine("Enter the day:");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());

            int dayOfWeek = FindDay(month, day, year);

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
