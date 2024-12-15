namespace demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] numbers = Console.ReadLine().Split();

            //SortedDictionary<string, int> keyValuePairs = new();

            //foreach (string key in numbers)
            //{
            //    if (keyValuePairs.ContainsKey(key))
            //    {
            //        keyValuePairs[key]++;
            //    }
            //    else
            //    {
            //        // adding         KEY, VALUE
            //        keyValuePairs.Add(key, 1);
            //    }
            //}
            //foreach (var key in keyValuePairs)
            //{
            //    Console.WriteLine($"{key.Key} -> {key.Value}");
            //}








            //string[] words = Console.ReadLine().Split();

            //Dictionary<string, int> pairs = new();

            ////for (int i = 0; i < words.Length; i++)
            ////{
            ////    words[i] = words[i].ToLower();
            ////}
            //foreach (string w in words)
            //{
            //    string word = w.ToLower();
            //    if (pairs.ContainsKey(word))
            //    {
            //        pairs[word] += 1;
            //    }
            //    else
            //    {
            //        pairs.Add(word, 1);
            //    }
            //}
            //foreach (var pair in pairs)
            //{
            //    if (pair.Value % 2 != 0)
            //    {
            //        Console.Write(pair.Key + " ");
            //    }
            //}





            int totalWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionary = new();

            for (int i = 0; i < totalWords; i++)
            {
                string keyWord = Console.ReadLine();
                string valueSynonym = Console.ReadLine();

                if (!dictionary.ContainsKey(keyWord))
                {
                    dictionary.Add(keyWord, new List<string>());
                }
                List<string> words = dictionary[keyWord];
                words.Add(valueSynonym);
            }

            foreach (var combo in dictionary)
            {
                string word = combo.Key;
                List<string> synonymList = combo.Value;
                Console.WriteLine($"{word} - {string.Join(", ", synonymList)}");
            }
        }
    }
}