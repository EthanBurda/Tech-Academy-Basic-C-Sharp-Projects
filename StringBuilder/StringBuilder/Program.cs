using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "michael ";
            string food = "likes to eat steaks on ";
            string day = "thursday.";
            name = name.ToUpper();
            Console.WriteLine(name + food + day);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Who eats steaks on thurday?");
            sb.AppendLine("Michael does!");
            sb.Append("I could eat steaks anyday of the week!");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
