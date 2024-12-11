namespace _06.MiddleCharacters
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            PrintMiddleCharacter(input);
        }

        static void PrintMiddleCharacter(string input)
        {
            int length = input.Length;
            int middleIndex = length / 2;

            if (length % 2 == 0)
            {
                Console.WriteLine($"{input[middleIndex - 1]}{input[middleIndex]}");
            }
            else
            {
                {
                    Console.WriteLine($"{input[middleIndex]}");
                }
            }
        }

    }
}
