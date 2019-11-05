using System;

namespace Convert_binary_object_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // выделить массив из 128 байт
            byte[] binaryObj = new byte[128];
            // заполнить массив случайными байтами
            (new Random()).NextBytes(binaryObj);

            Console.WriteLine("Binary Object as bytes:");
            for (int index = 0; index < binaryObj.Length; index++)
            {
                Console.WriteLine($"{binaryObj[index]:X} ");
            }
            Console.WriteLine();

            // преобразовать в строку Base64
            string encoded = Convert.ToBase64String(binaryObj);
            Console.WriteLine($"Binary Object as Base64: {encoded}");
        }
    }
}
