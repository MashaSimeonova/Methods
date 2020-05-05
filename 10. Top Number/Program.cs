using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isOdd = false;

            int checkOdd = 1;
            int checkNumberDivisible = 0;
            int diggit = 0;
            int sum = 0;

            Result(number, ref isOdd, ref checkOdd, ref checkNumberDivisible, ref diggit, ref sum);
        }

        private static void Result(int number, ref bool isOdd, ref int checkOdd, ref int checkNumberDivisible, ref int diggit, ref int sum)
        {
            for (int i = 17; i <= number; i++)

            {
                checkNumberDivisible = i;
                sum = 0;
                while (checkNumberDivisible != 0)
                {
                    diggit = checkNumberDivisible % 10;
                    sum += diggit;
                    checkNumberDivisible /= 10;

                }
                diggit = 0;

                if (sum % 8 == 0 && sum != 0 && sum != 1)
                {
                    checkOdd = i;
                    while (checkOdd != 0)
                    {
                        diggit = checkOdd % 10;

                        if (diggit % 2 != 0)
                        {
                            isOdd = true;
                            Console.WriteLine(i);
                            break;
                        }
                        checkOdd = checkOdd / 10;

                    }


                }


            }
        }
    }
}
