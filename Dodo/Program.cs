using System;

namespace Dodo
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = string.Empty;

            do
            {
                Console.Write("Enter your password: ");
                pass = Console.ReadLine();
            } while (pass != "secret");
            Console.WriteLine("Correct!");
        }
    }
}
