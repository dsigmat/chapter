using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 0; a < 101; a++)
            {
                if (((a % 3) == 0) & ((a % 5) == 0))
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if ((a % 3) == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if ((a % 5) == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(a);
                }
            }

           


        }
    }
}
