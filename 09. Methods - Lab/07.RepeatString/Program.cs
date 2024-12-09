namespace _07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                Console.Write(RepeatingText(input));
            }
        }
        static string RepeatingText(string input)
        { 
            return input;
        }
    }
}
