using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();


            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pgNum = Convert.ToInt32(pageNumber);
            Console.ReadLine();


            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);
            Console.ReadLine();


            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string PosExperience = Console.ReadLine();


            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();


            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrStud = Convert.ToInt32(hoursStudied);
            Console.ReadLine();


            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!");
            Console.ReadLine();
        }
    }
}
