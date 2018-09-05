using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 3;

            do
            {
                switch (number)
                {
                    case 49:
                        Console.WriteLine("You guessed 49. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 23:
                        Console.WriteLine("You guessed 23. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 82:
                        Console.WriteLine("You guessed 82. Try again.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("You picked 3, the best number! Congratulations!");
                        isGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess a number.");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.Read();
        }
    }
}
