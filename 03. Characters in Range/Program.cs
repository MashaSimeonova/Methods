using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main()
        {

            CharactersInRange();
        }
        static void CharactersInRange ()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if ((int)start<(int)end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    char wread = (char)i;
                    Console.Write(wread + " ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    char wread = (char)i;
                    Console.Write(wread + " ");
                }
            }

            
        }
       
    }
}
