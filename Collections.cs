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
            var list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddFirst(7);
            LinkedListNode<int> node = list.Find(2);
            list.AddBefore(node, 8);
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            Dictionary<int, string> db = new Dictionary<int, string>() { { 1, "english" }, { 2, "tamil" } };
            db.Add(3, "Maths");
            foreach(KeyValuePair<int, string> kvp in db)
            {
                Console.WriteLine(kvp.Value);
            }
            db[3] = "CS";
            foreach (KeyValuePair<int, string> kvp in db)
            {
                Console.WriteLine(kvp.Value);
            }
            SortedDictionary<string, string> collection = new SortedDictionary<string, string>();
            collection.Add("A", "Apple");
            collection.Add("Z", "Zeebra");
            collection.Add("R", "Demo");
            collection.Add("B", "Mango");
            foreach (KeyValuePair<string,string> kvp in collection)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            foreach (KeyValuePair<string, string> kvp in collection.OrderBy((x)=>x.Value))
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }


        }
    }
}
