using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program2
    {
        static void Main()
        {
            int[,] myArray = InitializeArray();
            int userInput = GetInput();
            int count = CountInteger(myArray, userInput);
            PrintOutput(count, userInput);
        }


        static int[,] InitializeArray()
        {
            int[,] theArray = new int[,]
            {
                {5,3 }, {2,9 }, {2,9 },
                {5,1 }, {7,1 }, {8,3 },
                {0,3 }, {2,2 }, {9,7 }
            };

            return theArray;
        }

        static int GetInput()
        {
            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static int CountInteger(int[,] anArray, int integerToFind)
        {
            int count = 0;

            for (int i = 0; i <= anArray.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= anArray.GetLength(1) - 1; j++)
                {
                    if (anArray[i, j] == integerToFind)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void PrintOutput(int count, int integerToFind)
        {
            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", integerToFind);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}.", integerToFind, count);
            }
        }
    }
}
