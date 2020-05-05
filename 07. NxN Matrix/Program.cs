using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumber(number);

        }

        private static void PrintNumber(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int colm = 0; colm < number; colm++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
