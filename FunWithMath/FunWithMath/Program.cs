using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number between 1 & 10,000,000.");
            string numberMult = Console.ReadLine();
            long numMult = Convert.ToInt64(numberMult);
            long product = numMult * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + product);
            Console.ReadLine();

            Console.WriteLine("Type a number between 1 & 10,000,000.");
            string numberAdd = Console.ReadLine();
            long numAdd = Convert.ToInt64(numberAdd);
            long total = numAdd + 25;
            Console.WriteLine("Your number plus 25 is: " + total);
            Console.ReadLine();

            Console.WriteLine("Type a number between 1 & 10,000,000.");
            string numberDiv = Console.ReadLine();
            long numDiv = Convert.ToInt64(numberDiv);
            float quotient = numDiv / 12.5f;
            Console.WriteLine("Your number divided by 12.5 is: " + quotient);
            Console.ReadLine();

            Console.WriteLine("Type a number between 1 & 10,000,000.");
            string numberGT = Console.ReadLine();
            long numGT = Convert.ToInt64(numberGT);
            bool trueOrFalse = numGT >= 50;
            Console.WriteLine("Is your number greater than 50: " + trueOrFalse);
            Console.ReadLine();

            Console.WriteLine("Type a number between 1 & 10,000,000.");
            string numberMod = Console.ReadLine();
            long numMod = Convert.ToInt64(numberMod);
            long remainder = numMod % 7;
            Console.WriteLine("The remainder of your number divided by 7 is: " + remainder);
            Console.ReadLine();

            Console.WriteLine("Thanks for playing \"Fun with math!\"");
            Console.ReadLine();
        }
    }
}
