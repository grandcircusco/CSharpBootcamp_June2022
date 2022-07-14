using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arithmetic
    {
        
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Multi(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Remainder(double x, double y)
        {
            return x % y;
        }

        public int TempConvert(int temp, string targetUnit)
        {
            int result = 0;
            if(targetUnit == "f")
            {
                result = (int)Math.Round((double)(temp *9/5) +32);
            }
            else if(targetUnit == "c")
            {
                result = (int)Math.Round((double)(temp - 32) * 5 / 9);
            }
            return result;
        }

        public string SuggestClothes(string eventType, int temp)
        {
            string result = "";

            if(eventType == "casual")
            {
                result = "Something Comfy ";
            }
            else if (eventType == "semi-formal")
            {
                result = "A polo ";
            }
            else if (eventType == "formal")
            {
                result = "A suit ";
            }

            if (temp < 54)
            {
                result += "A Coat";
            }
            else if (temp >= 54 && temp <= 70)
            {
                result += "A jacket";
            }
            else if (temp > 70)
            {
                result += "No Jacket";
            }

            return result;
        }

    }
}
