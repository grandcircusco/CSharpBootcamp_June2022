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
        public static bool InRange(double value, double min, double max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InRange(float value, float min, float max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool InRange(decimal value, decimal min, decimal max)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Return back a number
        public static int GetUserNumberInt()
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

        public static double GetUserNumberDouble()
        {
            double result = 0;
            Console.WriteLine("Please enter a number");
            //if parse fails, get input again
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input");
            }
            //input is now valid
            return result;
        }
        public static float GetUserNumberFloat()
        {
            float result = 0;
            Console.WriteLine("Please enter a number");
            //if parse fails, get input again
            while (!float.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid input");
            }
            //input is now valid
            return result;
        }

        public static decimal GetUserNumberDecimal()
        {
            decimal result = 0;
            Console.WriteLine("Please enter a number");
            //if parse fails, get input again
            while (!decimal.TryParse(Console.ReadLine(), out result))
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

        public static bool GetContinue(string message, string yes, string no)
        {
            //default value
            bool result = true;
            //check if user wants to continue
            while (true)
            {
                Console.WriteLine($"{message} {yes}/{no}");
                string choice = Console.ReadLine().Trim().ToLower();

                //Check user input
                if (choice == yes.ToLower())
                {
                    result = true;
                    break;
                }
                else if (choice == no.ToLower())
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
