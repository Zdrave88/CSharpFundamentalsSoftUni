namespace demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            SortedDictionary<string, int> keyValuePairs = new SortedDictionary<string, int>();

            foreach (string number in numbers)
            {
                if (!keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs.Add(number, 1);
                }
                else
                {
                    keyValuePairs[number]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in keyValuePairs)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}