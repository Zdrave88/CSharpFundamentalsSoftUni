


namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (isPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        static bool isPalindrome(string input)
        {
            bool isPalidrome = false;   
            char[] characters = input.ToCharArray();
            Array.Reverse(characters);
            string reversedInput = new string(characters);

            if (reversedInput == input) 
            {
                isPalidrome = true;
            }
            return isPalidrome;

        }
    }
}
