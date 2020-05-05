using System;
using System.Linq;
namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            var forward = "";
            var reverse = "";

            PilindromeCheck(ref stringInput, ref forward, ref reverse);
        }

        private static void PilindromeCheck(ref string stringInput, ref string forward, ref string reverse)
        {
            while (stringInput != "END")
            {
                forward = new string(stringInput.ToCharArray());
                reverse = new string(stringInput.ToCharArray().Reverse().ToArray());

                if (forward == reverse)
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false");
                }
                stringInput = Console.ReadLine();
            }
        }
    }
}
