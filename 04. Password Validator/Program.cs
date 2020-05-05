using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValidChar = CharactersCheck(input); ;
            bool isValidLetter = ContainsCheck(input);
            bool isValidDiggit = true;
           
            
            DigitCheck(input, isValidDiggit);
            if (CharactersCheck(input)&& ContainsCheck(input)&& DigitCheck(input, isValidDiggit))
            {
                Console.WriteLine("Password is valid");
            }


        }
        static bool CharactersCheck(string input)
        {
          

            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;

            }
           
            return true;
        }
        static bool ContainsCheck(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                
                if (!(char.IsLetterOrDigit(input[i])))
                {
                    
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                    
                }
                
            }
            return true;
            
        }
        static bool DigitCheck(string input, bool isValid)
        {
            
            int digitCounter = 0;

            isValid = false;

            for (int i = 0; i < input.Length; i++)
            {
                char digit = input[i];
                if (char.IsDigit(digit))
                {
                    digitCounter++;
                }
            }
            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            else
            {
                isValid = true;
            }
            return isValid;
        }
       

    }
}
