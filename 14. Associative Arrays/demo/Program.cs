namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> countries = new();
            //countries["Bulgaria"] = "Sofia";     // index 0
            //countries["France"] = "Paris";       // index 1
            //countries["USA"] = "Washington";     // index 2

            //Console.WriteLine(countries["Bulgaria"]); // => Sofia
            //Console.WriteLine(countries["France"]); // => Paris

            //if (countries.ContainsValue("Sofia"))
            //{
            //    Console.WriteLine($"The dictionary countries contains Sofia as a value");
            //}
            //Console.WriteLine("Printing only the keys:");
            //foreach (var country in countries)
            //{
            //    Console.WriteLine(country.Key);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Printing only the values:");
            //foreach (var country in countries)
            //{
            //    Console.WriteLine(country.Value);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Printing the dictionary:");
            //foreach (var country in countries)
            //{
            //    Console.WriteLine(country);
            //}


            //Dictionary<string, string> cities = new()
            //{
            //    { "Bulgaria", "Plovdiv" }
            //  , { "Germany", "Aachen"}
            //  , { "Poland", "Krakow"}
            //};
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //cities["Bulgaria"] = "Pirdop";
            //cities["Germany"] = "Ulm";
            //cities["Poland"] = "Auschwitz";
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Dictionary<int, string> numbersAsWords = new()
            //{
            //    {1, "One" },
            //    {2, "Two" },
            //    {5, "Five" }
            //};
            //foreach (var number in numbersAsWords)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();
            //numbersAsWords.Add(3, "three");
            //numbersAsWords.Add(4, "four");
            //numbersAsWords.Add(6, "six");
            //numbersAsWords.Remove(5);
            //numbersAsWords.Add(11, "eleven");

            //foreach (var number in numbersAsWords)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine();

            //foreach (var number in numbersAsWords)
            //{
            //    Console.WriteLine($"{number.Key}: {number.Value}");
            //}


            //string[] numbers = Console.ReadLine().Split();
            //// create SortedDictionary
            //SortedDictionary<string, int> keyValuePairs = new();
            //// go through all elements in the []/<>
            //foreach (string num in numbers)
            //{
            //    // if the number is already in []/<>
            //    if (keyValuePairs.ContainsKey(num))
            //    {
            //        // increase the occurances(VALUE) by1/++
            //        keyValuePairs[num]++;
            //    }
            //    else
            //    {
            //        // otherwise add the number(KEY) in the dictionary with 1 occurances(VALUE)
            //        keyValuePairs.Add(num, 1);
            //    }
            //}

            //foreach (var pair in keyValuePairs)
            //{
            //    Console.WriteLine($"{pair.Key} -> {pair.Value}");
            //}



            int totalWords = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionary = new();

            for (int i = 0; i < totalWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = new List<string>();
                }
                dictionary[word].Add(synonym);

            }
        }
    }
}

