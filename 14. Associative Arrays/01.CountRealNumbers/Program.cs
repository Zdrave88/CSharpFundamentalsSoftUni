namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            SortedDictionary<string, int> keyValuePairs = new();

            foreach (string key in numbers)
            {
                if (keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key]++;
                }
                else
                {
                    keyValuePairs.Add(key, 1);
                }
            }
            foreach (var key in keyValuePairs)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}
