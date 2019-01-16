using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace jan19Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runP = true;
            string firstName = nameValid();
            while (runP == true)
            {
                int i;
                long factorial;
                {
                    Console.WriteLine("{0}, Please enter an integer between 1 and 10", firstName);
                    int.TryParse(Console.ReadLine(), out int number);
                    factorial = number;
                    for (i = number - 1; i >= 1; i--)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("\nThe factorial of {0} is: " + factorial, number);
                }
                runP = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("\nWould you like to run the application again? (Y or N)");
            string input = Console.ReadLine().ToLower();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Thank you, Goodbye!");
                Console.ReadLine();
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }
        public static string nameValid()
        {
            bool responseValid = true;
            string firstName = "";
            while (responseValid)
            {
                Console.WriteLine("Please enter your first name");
                firstName = Console.ReadLine();

                if (!Regex.IsMatch(firstName, @"^[A-Z]+[A-z]{2,30}$"))
                {
                    Console.WriteLine("I'm sorry, this is not a valid name");
                }
                else
                {
                    Console.WriteLine("Name is valid");
                    break;
                }
            }
            return firstName;
        }
    }
}
