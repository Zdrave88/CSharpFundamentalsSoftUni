using System;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace demostration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] arguments = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                switch (action)
                {
                    case "Contains":
                        CheckForElement(arguments[1], key);
                        break;
                    case "Flip":
                        key = ChangePartialCasing(arguments[1], int.Parse(arguments[2]), int.Parse(arguments[3]), key);
                        break;
                    case "Slice":
                        key = SliceKey(int.Parse(arguments[1]), int.Parse(arguments[2]), key);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {key}");
        }

        static string CheckForElement(string substring, string key)
        {
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
            return key;
        }

        static string ChangePartialCasing(string casing, int startIndex, int endIndex, string key)
        {
            string substring = key.Substring(startIndex, endIndex - startIndex);
            string changedSubstring = string.Empty;
            if (casing == "Upper")
            {
                changedSubstring = substring.ToUpper();
            }
            else
            {
                changedSubstring = substring.ToLower();
            }
            key = key.Replace(substring, changedSubstring);
            Console.WriteLine(key);
            return key;
        }

        static string SliceKey(int startIndex, int endIndex, string key)
        {
            key = key.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(key);
            return key;
        }
    }
}
