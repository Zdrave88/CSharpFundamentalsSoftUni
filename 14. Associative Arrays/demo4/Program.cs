namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> dictionaryMap = new Dictionary<string, int>();  
            
            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                if (!dictionaryMap.ContainsKey(lowerWord))
                {
                    dictionaryMap.Add(lowerWord, 1);
                }
                else
                { 
                    dictionaryMap[lowerWord] += 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in dictionaryMap.Where(p =>p.Value % 2 != 0))
            {
                Console.Write(pair.Key + " ");                
            }
        }
    }
}
