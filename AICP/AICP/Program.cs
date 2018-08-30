using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            String hourRate1 = Console.ReadLine();
            Decimal hrRate1 = Convert.ToDecimal(hourRate1);
            Console.WriteLine("Hours worked per week?");
            String hourWorked1 = Console.ReadLine();
            Decimal hrWorked1 = Convert.ToDecimal(hourWorked1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            String hourRate2 = Console.ReadLine();
            Decimal hrRate2 = Convert.ToDecimal(hourRate2);
            Console.WriteLine("Hours worked per week?");
            String hourWorked2 = Console.ReadLine();
            Decimal hrWorked2 = Convert.ToDecimal(hourWorked2);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary of Person 1:");
            Decimal wkSalary1 = hrRate1 * hrWorked1;
            Console.WriteLine(wkSalary1);
            Console.ReadLine();

            Console.WriteLine("Weekly Salary of Person 2:");
            Decimal wkSalary2 = hrRate2 * hrWorked2;
            Console.WriteLine(wkSalary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = wkSalary1 > wkSalary2;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
        }
    }
}
