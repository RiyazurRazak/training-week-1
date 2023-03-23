namespace week_1
{
    internal class Basics
    {

        public static void ScoreHandller(ref int score)
        {
            score /=  2;
        }

        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
          
            Console.WriteLine("Enter the input!");
            string input = Console.ReadLine(); // geting the value from the user
            Console.WriteLine("The Entered Input is :" + input);
            int valueA = 5;
            double valueB = 10.5;
            Console.WriteLine(valueA * valueB);
            ScoreHandller(ref valueA);
            Console.WriteLine(valueA * valueB);
            if (valueB.GetType() == typeof(double))
            {
                Console.WriteLine("The ValueB variable is a double type");
            }
            else
            {
                Console.WriteLine("The ValueB variable is a not double type");
            }
            string userMailId = "riyazurrazak@example.com";
            Console.WriteLine("Identifier in the mail is " + userMailId.Split('@')[0]);
            Console.WriteLine("domain in the mail is " + userMailId.Split('@')[1]);
            string[] usernames = { "Riyaz", "Sanjai", "Nanthakumar", "Vishnu" };
            Console.WriteLine("The Total usernames are: " + usernames.Length);
            foreach(string username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}