using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = "Vic";
            Greet(name);

            Console.WriteLine($"The current time is {DateTime.Now}");
        }

        static void Greet(string name)
        {
            if(String.IsNullOrEmpty(name)) return;

            Console.WriteLine($"Hello, {name}!");
        }

    }
}
