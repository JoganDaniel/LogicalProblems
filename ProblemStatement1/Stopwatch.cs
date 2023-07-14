using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    public class Stopwatch
    {
        const string START = "start", STOP = "stop";
        public void RunStopwatch()
        {
            
            Console.WriteLine("Enter start to run");
            string input = Console.ReadLine();
            if (input.Equals(START))
            {
                DateTime time1 = DateTime.Now;
                int hour1 = time1.Hour;
                int minute1 = time1.Minute;
                int second1 = time1.Second;
                Console.WriteLine("Enter stop to stop the stopwatch");
               
                string endInput= Console.ReadLine();
                if (endInput.Equals(STOP)) { 
                    DateTime time2 = DateTime.Now;
                    int hour2 = time2.Hour;
                    int minute2 = time2.Minute;
                    int second2 = time2.Second;
                    Console.WriteLine((hour2 - hour1) + " : " + (minute2 - minute1) + " : " +( second2 - second1));
                }

            }
        }
    }
}
