using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            VowelsCounter(count);
        }
        static void VowelsCounter(int count)
        {
            string word = Console.ReadLine();
            count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char diggit = (char)word[i];

                if (diggit == 'a' || diggit == 'o' || diggit == 'u' || diggit == 'e' || diggit == 'i' || diggit == 'A' || diggit == 'O' || diggit == 'E' || diggit == 'I' || diggit == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
