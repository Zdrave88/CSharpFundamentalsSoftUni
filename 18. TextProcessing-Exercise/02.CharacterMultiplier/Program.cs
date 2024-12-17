
namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(" ");
            string text1 = input[0];
            string text2 = input[1];
            Console.WriteLine(CulcateSum(text1, text2));

        }
        static int CulcateSum(string text1, string text2)
        {
            int result = 0;
            int length = Math.Max(text1.Length, text2.Length);

            for (int i = 0; i < length; i++)
            {
                if (i < text1.Length && i < text2.Length)
                {
                    result += text1[i] * text2[i];
                }
                else if (i < text1.Length)
                {
                    result += text1[i];
                }
                else
                {
                    result += text2[i];
                }
            }
            return result;
        }
    }
}
