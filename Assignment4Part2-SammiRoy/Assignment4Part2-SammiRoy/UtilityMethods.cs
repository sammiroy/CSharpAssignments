using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Part2_SammiRoy
{
    internal class UtilityMethods
    {
        public static int GetPositiveInteger(string prompt)
        {
            string input;
            int result;
            Console.Write(prompt);
            input = Console.ReadLine();

            while (!int.TryParse(input, out result) || result <= 0)
            {
                Console.WriteLine("You must enter a positive integer!");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return result;
        }



        //Method to prompt for a non Empty String. It will receive a prompt as a parameter.
        // string.IsNullOrEmpty(valuetocheck)     --Returns True if empty/Blank

        public static string GetNonEmptyString(string prompt)
        {
            string input;
            Console.Write(prompt);
            input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Gotta give some data!");
                Console.Write(prompt);
                input = Console.ReadLine();
            }
            return input;
        }
    }
}
