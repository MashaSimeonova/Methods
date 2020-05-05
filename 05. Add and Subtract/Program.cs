using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNUm = int.Parse(Console.ReadLine());
            int secondNUm = int.Parse(Console.ReadLine());
            int thirdNUm = int.Parse(Console.ReadLine());
          
           int sum = Sum(firstNUm, secondNUm);
            Console.WriteLine(Substrac(sum,thirdNUm));
        }
        static int Sum(int firstNum, int secondNum)
        {
            int sum = firstNum + secondNum;
            return sum;
        }
        static int Substrac(int sum, int thirdNum)
        {
            int finalSum = sum - thirdNum;
            return finalSum;
        }
    }
}
