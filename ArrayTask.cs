using System;
using System.Collections;

namespace week_1
{
    internal class ArrayTask
    {
        static void Main(string[] args)
        {

            // first question

            int[] duplicateValueArray = { 1, 1, 2, 3, 4, 5, 6, 4, 2, 56, 45, 3 };
            HashSet<int> distinctContainer = new HashSet<int>();
            foreach (int value in duplicateValueArray)
            {
                distinctContainer.Add(value);
            }
            int totalDuplicateElements = duplicateValueArray.Length - distinctContainer.Count;
            Console.WriteLine("Total duplicate values are: " +totalDuplicateElements);

            // Second Question

            const int maxRange = 10;
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            for(int number=1; number<=maxRange; number++)
            {
                if(number % 2 == 0) evenNumbers.Add(number);
                else oddNumbers.Add(number);
            }
            Console.WriteLine("Odd Numbers are :");
            foreach(int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Even Numbers are :");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
