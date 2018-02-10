using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class InputUtility
    {
        public static int ReadInteger(string prompt)
        {
            bool isParseDone;
            int userInput;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                isParseDone = Int32.TryParse(input, out userInput);
            } while (isParseDone == false);

            return userInput;
        }

        public static int ReadInteger()
        {
            return ReadInteger("Please enter an integer: ");

            //int x = ReadInteger("Please enter an integer: ");
            //return x;
        }
    }
}
