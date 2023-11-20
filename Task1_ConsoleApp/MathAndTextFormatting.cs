using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ConsoleApp
{
    public static class MathAndTextFormatting
    {
        public static int Add(int number1, int number2) 
        {
            return number1 + number2;
        }
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public static string PossiblyUppercaseAndDecorateText(string text, bool toUpper, bool decorate)
        {
            if (toUpper)
            {
                text = text.ToUpper();
            }
            if (decorate)
            {
                text = $"-:{text}:-";
            }
            return text;

        }
        public static string TellIfNegativeOrTheRelationTo100(int number)
        {
            string result = "";
            if (number < 0)
            {
                result= $"{number} is a negative number";
            }
        else if (number > 0&& number<=100) 
            {
               result= $"Add {100-number} to {number} and you get 100";
            }
        else if (number > 100)
            {
                result = $"{number} is greater than 100";
            }
            return result;
        }
    }
}
