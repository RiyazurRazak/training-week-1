using System;


namespace week_1
{
    internal class Collections
    {
        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
            var users = new List<string>();
            users.Add("Riyaz");
            users.Add("Sanjai");
            users.AddRange(new string[] { "Nantha", "Vishnu", "Ragul" });
            Console.WriteLine(users.Count);
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            users.Remove("Nantha");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
            var data = new HashSet<int>() { 1,2,3,4,5};
            data.Add(6);
            data.Add(1);
            data.Add(2);
            foreach (var number in data)
            {
                Console.WriteLine(number);
            }
            var studentIds = new SortedSet<int>() { 17, 14, 18, 12};
            foreach (var id in studentIds)
            {
                Console.WriteLine(id);
            }
            Stack<string> stackCollection = new Stack<string>();
            stackCollection.Push("A");
            stackCollection.Push("B");
            while (stackCollection.Count > 0)
            {
                Console.WriteLine("Peak Element is " + stackCollection.Peek());
                Console.WriteLine(stackCollection.Pop());
               
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("And");
            queue.Enqueue("OR");
            while (queue.Count > 0)
            {
                Console.WriteLine("Peak Element is " + queue.Peek());
                Console.WriteLine(queue.Dequeue());

            }
        }
    }
}
