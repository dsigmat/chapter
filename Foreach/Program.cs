using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Adam", "Barry", "Charlie" };

            foreach (var item in names)
            {
                Console.WriteLine($"name: {item} has {item.Length} characters.");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
