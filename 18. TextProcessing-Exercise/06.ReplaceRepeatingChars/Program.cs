namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < input.Length; i++)
            { 
                char currentSymbol = input[i];
                if (i == input.Length - 1 || currentSymbol != input[i + 1])
                {
                    result += (char)(currentSymbol);
                }
            }
            Console.WriteLine(result);

        }
    }
}
