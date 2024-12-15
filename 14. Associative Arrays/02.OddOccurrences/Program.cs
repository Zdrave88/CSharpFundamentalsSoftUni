namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower();
            }

            Dictionary<string, int> keyValuePairs = new();

            foreach (string word in words)
            {
                if (keyValuePairs.ContainsKey(word))
                {
                    // the COLLECTION already contains the KEY(word)
                    // so increase the VALUE  (+=1 / ++)
                    keyValuePairs[word] += 1;
                }
                else
                {
                    // the COLLECTION do not contains the KEY(word)
                    // so add KEY(word), VALUE = 1
                    keyValuePairs.Add(word, 1);
                }
            }
            // check if the value is ODD = value % 2 != 0
            foreach (var pair in keyValuePairs)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }

            }
        }
    }
}
