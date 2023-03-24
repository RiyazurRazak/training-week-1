using System;

namespace week_1
{
    internal class StringTask
    {

        static string Modifier(string input)
        {
            char[] arr = input.ToCharArray();
            char temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            return new string(arr);
        }

        static string AddLastCharToFrontAndBack(string input)
        {
            string lastChar = input.Substring(input.Length - 1);
            return  lastChar + input + lastChar;
        }

        static string Validation(string input)
        {
            string output = "";
            string[] sanitizeValue = input.Split("ok");
            foreach (string s in sanitizeValue)
            {
                output += s;
            }
            return output;
            
        }
        static void Main(string[] args)
        {
            string input = "riyaz";
            //first question
            Console.WriteLine(Modifier(input));
            //second question
            Console.WriteLine(AddLastCharToFrontAndBack(input));
            //third question
            string testCase1 = "riyaz";
            string testCase2 = "itisoknoworriesok";
            Console.WriteLine(Validation(testCase1));
            Console.WriteLine(Validation(testCase2));
        }
    }
}
