using System;

namespace Parsing_strings_to_convert_to_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse("38");
            DateTime birthday = DateTime.Parse("4 july 1980");
            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}");


            Console.Write("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} aggs.");
            }
            else
            {
                Console.WriteLine("I cloud not parse the input.");
            }
        }
    }
}
