using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting
{
    public class VendingMachine
    {
        public void Vendingmachine()
        {
            int[] notes = { 1000, 500, 200, 100, 50, 20, 10 };
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            List<int> changeNotes = new List<int>();

            for (int i = 0; i < notes.Length; i++)
            {
                if (amount >= notes[i])
                {
                    int count = amount / notes[i];
                    amount %= notes[i];
                    for (int j = 0; j < count; j++)
                        changeNotes.Add(notes[i]);
                }
            }
            foreach (int note in changeNotes)
                Console.Write(note + " ");
        }
    }
}