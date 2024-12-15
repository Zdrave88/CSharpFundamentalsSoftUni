namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (string word in input)
            {
                foreach (char letter in word)
                {
                    if (dictionary.ContainsKey(letter))
                    {
                        dictionary[letter] += 1;
                    }
                    else
                    {
                        dictionary.Add(letter, 1);
                    }
                }
            }
            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

            //string input = Console.ReadLine();
            //Dictionary<char, int> dictionaryMap = new Dictionary<char, int>();

            //foreach (char letter in input)
            //{
            //    if (letter == ' ')
            //    {
            //        continue;
            //    }
            //    else if (!dictionaryMap.ContainsKey(letter))
            //    {
            //        dictionaryMap.Add(letter, 1);
            //    }
            //    else
            //    {
            //        dictionaryMap[letter]++;
            //    }
            //}
            //foreach (KeyValuePair<char, int> pair in dictionaryMap)
            //{
            //    Console.WriteLine($"{pair.Key} -> {pair.Value}");
            //}
        }
    }
}
