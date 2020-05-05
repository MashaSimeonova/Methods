using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int SecondNum = int.Parse(Console.ReadLine());

           double sumFirstFac = FirstFac(firstNum);
            double sumSecondfac = FirstFac(SecondNum);
          
            Result(sumFirstFac, sumSecondfac);
        }

        private static void Result(double sumFirstFac, double sumSecondfac)
        {
            double result = sumFirstFac /sumSecondfac;
            Console.WriteLine($"{result:f2}");
        }

        private static double FirstFac(int firstNum)
        {
            double sumFirstFac = 1;
            for (int i = 1; i <= firstNum; i++)
            {
                sumFirstFac *= i;
            }

            return sumFirstFac;
        }
    }
}
