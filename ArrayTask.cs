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

            // second question

            int[] arrayA = new int[] { 1, 2, 5, 3, 4 };
            int[] arrayB = new int[] { 7, 6, 9, 10, 8 };
            int[] mergeArray = new int[arrayA.Length + arrayB.Length];
            Array.Sort(arrayA);
            Array.Sort(arrayB);
            for(int i=0; i<arrayA.Length+arrayB.Length; i++)
            {
               
                if(i < arrayA.Length)
                {
                    mergeArray[i] = arrayA[i];
                }
                else
                {
                    mergeArray[i] = arrayB[i - (arrayA.Length)];
                }
            }
            Console.WriteLine("Merged Array");
            foreach(int value in mergeArray) {
                Console.Write(value + ", ");
            }
            Console.WriteLine();
            

            // third Question

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
