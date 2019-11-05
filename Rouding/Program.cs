using System;

namespace Rouding
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 9.49;
            double b = 9.5;
            double c = 10.49;
            double d = 10.5;

            Console.WriteLine($"a is {a}, ToInt(a) is {Convert.ToInt32(a)}");
            Console.WriteLine($"b is {b}, ToInt(a) is {Convert.ToInt32(b)}");
            Console.WriteLine($"c is {c}, ToInt(a) is {Convert.ToInt32(c)}");
            Console.WriteLine($"d is {d}, ToInt(a) is {Convert.ToInt32(d)}");
        }
    }
}
