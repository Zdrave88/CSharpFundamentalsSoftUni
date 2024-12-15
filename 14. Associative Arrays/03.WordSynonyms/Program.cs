using System;
using System.Collections.Generic;

class SynonymsDictionary
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string keyWord = Console.ReadLine();    // WORD
            string valueSynonym = Console.ReadLine();  // SYNONYM

            // check if the ductionary DO NOT contain string keyWord as a KEY in the dictionary
            if (!synonyms.ContainsKey(keyWord))
            {
                // since the dictionary DO NOT contain keyWord/word as KEY
                // SET keyWord/word as KEY
                synonyms[keyWord] = new List<string>();
            }
            // add valueSynonym/synonym as VALUE/list in the dictionary
            synonyms[keyWord].Add(valueSynonym);
        }

        foreach (var element in synonyms)
        {
            string word = element.Key;
            List<string> synonymList = element.Value;

            Console.WriteLine($"{word} - {string.Join(", ", synonymList)}");
        }
    }
}
