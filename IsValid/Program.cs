using System;

namespace IsValid
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLengthValid = isLengthValideee(password);
            bool areSymbolsValid = SymbolsValid(password);
            bool containseDiggit = ContainsDiggit(password);

            PrintResult(isLengthValid, areSymbolsValid, containseDiggit);

        }

        private static void PrintResult(bool isLengthValid, bool areSymbolsValid, bool containseDiggit)
        {
            if (!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!areSymbolsValid)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!containseDiggit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isLengthValid && areSymbolsValid && containseDiggit)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ContainsDiggit(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                    if (counter == 2)
                    {
                        return true;
                    }
                }
               
            }
           
            return false;
          
        }
        private static bool SymbolsValid(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
               
                char diggit = password[i];

                if (!(char.IsLetterOrDigit(diggit)))
                {
                    return false;

                }

            }
            return true;
        }

        private static bool isLengthValideee(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
