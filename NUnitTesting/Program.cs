using NUnitTesting;
using System;
using System.Diagnostics;

public class Program
{
    private static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("1.Vending Machine\n2.Day of the Wek\n3.Convert Temperature\n4.Monthly Payment\n5.Exit");
            int ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (ch)
            {
                case 1:
                    VendingMachine machine = new VendingMachine();
                    machine.Vendingmachine();
                    break;
                case 2:
                    DaysOfWeek daysOfWeek = new DaysOfWeek();
                    daysOfWeek.Day();
                    break;
                case 3:
                    Temperature temperature = new Temperature();
                    temperature.ConvertTemp();
                    break;
                case 4:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Payment();
                    break;
                case 5:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Enter Correct choice");
                    break;
            }
            Console.WriteLine();
        }
}
}