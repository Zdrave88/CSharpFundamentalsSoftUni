
namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            Console.WriteLine(PrintVowelsCount(textInput));
        }

        static int PrintVowelsCount(string textInput)
        {
            int vowelsCount = 0;
            foreach (char sym in textInput.ToLower())
            {
                switch (sym)
                {
                    case 'a': vowelsCount++; break;
                    case 'e': vowelsCount++; break;
                    case 'o': vowelsCount++; break;
                    case 'i': vowelsCount++; break;
                    case 'u': vowelsCount++; break;
                }
                
            }
            return vowelsCount;
        }
    }
}