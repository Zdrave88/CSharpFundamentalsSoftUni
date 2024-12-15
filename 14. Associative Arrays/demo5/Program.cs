using System.Xml.Linq;

namespace demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rotation = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionaryMap = new Dictionary<string, List<string>>();

            for (int i = 0; i < rotation; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                if (!dictionaryMap.ContainsKey(key))
                { 
                    dictionaryMap[key] = new List<string>();
                }
                dictionaryMap[key].Add(value);
            }
            foreach (KeyValuePair<string, List<string>> pair in dictionaryMap)
            { 
                List<string> list = pair.Value;
                Console.WriteLine($"{pair.Key} - {string.Join(", ", list)}");
            }
        }
    }
}