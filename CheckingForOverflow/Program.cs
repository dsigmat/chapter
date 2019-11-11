using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //При переполнении инструкция checked передает .NET команду вызова исключения вместо отсутствия реакции на переполнение.
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                    x++;
                    Console.WriteLine(x);
                    x++;
                }
                unchecked
                {
                    int y = int.MaxValue + 1;
                    Console.WriteLine(y);
                    y--;
                    Console.WriteLine(y);
                    y--;
                    Console.WriteLine(y);
                    y--;
                    Console.WriteLine(y);
                    y--;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The code overflowed but I caught the exeption.");
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
