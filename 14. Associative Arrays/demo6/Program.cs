namespace demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            foreach (string word in words.Where(w => w.Length % 2 == 0))
            {
                Console.WriteLine(word);
            }
        }
    }
}
