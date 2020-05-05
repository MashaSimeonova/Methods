using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = 0;
            SmallestNumb(smallest);
        }
        static void SmallestNumb(int smallest)
        {
            int checkSmall = 0;
            smallest = 0;
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                checkSmall = secondNum;
            }
            else
            {
                checkSmall = firstNum;
            }
            if (checkSmall > thirdNum)
            {
                smallest = thirdNum;
            }
            else
            {
                smallest = checkSmall;
            }

            Console.WriteLine(smallest);
        }
    }
}
