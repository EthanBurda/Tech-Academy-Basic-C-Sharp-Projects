using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            string packageWeight = Console.ReadLine();
            decimal pkgkWeight = Convert.ToInt32(packageWeight);

            if (pkgkWeight >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Please enter the package width:");
                string packageWidth = Console.ReadLine();
                int pkgWidth = Convert.ToInt32(packageWidth);


                Console.WriteLine("Please enter the package height:");
                string packageHeight = Console.ReadLine();
                int pkgHeight = Convert.ToInt32(packageHeight);

                Console.WriteLine("Please enter the package length:");
                string packageLength = Console.ReadLine();
                int pkgLength = Convert.ToInt32(packageLength);

                int pkgSum = pkgWidth + pkgHeight + pkgLength;

                decimal cost = (pkgSum * pkgkWeight) / 100;

                if (pkgSum >= 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }

                else
                {
                    Console.WriteLine("Your estimated total for shipping this package is: $" + cost);
                }
                Console.WriteLine("Thank You!");
                Console.ReadLine();
            }
        }
    }
}
