using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintResult(input);

        }

        private static void PrintResult(string input)
        {
            if (input.Length % 2 == 0)
            {
                for (int i = input.Length / 2 - 1; i <= input.Length - input.Length / 2; i++)
                {
                    Console.Write(input[i]);
                }
            }
            else
            {
                for (int i = input.Length / 2; i < input.Length - input.Length / 2; i++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}
