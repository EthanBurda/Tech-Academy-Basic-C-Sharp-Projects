using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");         
            string driverAge = Console.ReadLine();
            int age = Convert.ToInt32(driverAge);

            Console.WriteLine("Have you ever had a DUI?");
            string driverDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(driverDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string driverTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(driverTickets);

            Console.WriteLine("Qualify?");
            bool qualify = (age > 15 && DUI == false && tickets <= 3);
            Console.WriteLine(qualify);
            Console.ReadLine();

        }
    }
}
