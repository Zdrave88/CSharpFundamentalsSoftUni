
namespace demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            string textResult = PrintTextResult(textInput);
            Console.WriteLine(textResult);
        }

        static string PrintTextResult(string? textInput)
        {   
            string result = string.Empty;
            for (int i = 0; i < textInput.Length; i++)
            {
                char currentSymbol = textInput[i];

                if (i == textInput.Length -1 || currentSymbol != textInput[i + 1])
                {
                    result += currentSymbol;
                }
            }
            return result;
        }
    }
}
