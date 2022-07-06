using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    internal class Validator
    {
        //Checks if value is between min and max
        public static bool InRange(int value, int min, int max)
        {
            if(value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Return back a number
        public static int GetUserNumber()
        {
            int result = 0;
            Console.WriteLine("Please enter a number");
            //if parse fails, get input again
            while(!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input");
            }
            //input is now valid
            return result;
        }

        public static bool GetContinue()
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine("Would you like to continue? y/n");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if(choice == "y")
                {
                    result = true;
                    break;
                }
                else if(choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was invalid. Try again.");
                }
            }
            return result;
        }

        //Overloaded. Allows for custom message
        public static bool GetContinue(string message)
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine($"{message} y/n");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("That was invalid. Try again.");
                }
            }
            return result;
        }



    }
}
