using System;

namespace week_1
{
    internal class BestPractices
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            int[] range = { 1, 2, 3, 4, 5 };
            try
            {
                Console.WriteLine(range[2]);
                if (age < 18) {
                    throw new MinorAgeException("Age is less than 18. Not eligible for voting");
                }
                else
                {
                    Console.WriteLine("Proceed For Voting Process!");
                }
            }catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MinorAgeException ex)
            {
                Console.WriteLine("Not Allowed To Vote!! \n" + "Error Message : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.WriteLine("Finally called"); }
        }

        public class MinorAgeException : Exception
        {
            public MinorAgeException(string message) : base(message) { }

        }
    }
}
