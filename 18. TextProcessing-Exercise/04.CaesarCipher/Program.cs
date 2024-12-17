namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;
            foreach (char symbol in input)
            {

                result += (char)(symbol + 3);

            }
            Console.WriteLine(result);
        }
    }
}
