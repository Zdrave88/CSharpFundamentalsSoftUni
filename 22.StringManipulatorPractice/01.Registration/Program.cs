using System.ComponentModel;

namespace _01.Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Registration")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                switch (action)
                {
                    case "Letters":
                        username = ChangeCasing(arguments[1], username);
                        break;
                    case "Reverse":
                        ReversePartOfUsername(int.Parse(arguments[1]), int.Parse(arguments[2]), username);
                        break;
                    case "Substring":
                        username = CutPartOfUsername(arguments[1], username);
                        break;
                    case "Replace":
                        username = ReplaceUsernameElements(char.Parse(arguments[1]), username);
                        break;
                    case "IsValid":
                        CheckIfUsernameIsValid(char.Parse(arguments[1]), username);
                        break;
                }

            }
        }
        static string CheckIfUsernameIsValid(char symbol, string username)
        {
            if (username.Contains(symbol))
            {
                Console.WriteLine("Valid username.");
            }
            else
            {
                Console.WriteLine($"{symbol} must be contained in your username.");
            }
            return username;
        }

        static string ReplaceUsernameElements(char element, string? username)
        {
            char replacement = '-';
            if (username.Contains(element))
            {
                username = username.Replace(element, replacement);
                Console.WriteLine(username);
            }
            return username;
        }

        static string CutPartOfUsername(string substring, string? username)
        {
            if (username.Contains(substring))
            {
                int index = username.IndexOf(substring);
                //string replacement = username.Substring(index, substring.Length);

                username = username.Remove(index, substring.Length);
                Console.WriteLine(username);
            }
            else
            {
                Console.WriteLine($"The username {username} doesn't contain {substring}.");
            }
            return username;
        }

        static void ReversePartOfUsername(int startIndex, int endIndex, string username)
        {
            if (startIndex >= 0 && endIndex < username.Length && startIndex <= endIndex)
            {
                string substring = username.Substring(startIndex, endIndex - startIndex + 1);
                string reversed = new string(substring.Reverse().ToArray());
                Console.WriteLine(reversed);
            }
            else
            {
                Console.WriteLine("Invalid indices.");
            }
        }

        static string ChangeCasing(string casing, string username)
        {
            if (casing == "Lower")
            {
                username = username.ToLower();
            }
            else        //"Upper"
            {
                username = username.ToUpper();
            }
            Console.WriteLine(username);
            return username;
        }
    }
}
