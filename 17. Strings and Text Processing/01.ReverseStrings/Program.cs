namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end")
                {
                    break;
                }
                List<string> output = new List<string>();

                foreach (char letter in text)
                {
                    output.Add(letter.ToString());
                }
                output.Reverse();
                Console.WriteLine($"{text} = {string.Join("", output)}");
            }


        }
    }
}
