using System;

namespace week_1
{
     class Generics<Type>
    {
        public Generics(Type message)
        {
            Console.WriteLine(message);
        }
       
    }
    class Runner
    {

        public static void GenericMethod<T>(T message) {
            Console.WriteLine(message);
        }
        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
            Generics<int> a = new Generics<int>(155);
            Generics<string> b = new Generics<string>("Riyaz");
            GenericMethod("hai");
            GenericMethod(5);
        }
    }
}
