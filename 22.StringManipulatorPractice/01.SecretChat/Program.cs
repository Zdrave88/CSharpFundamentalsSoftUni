using System.Threading.Channels;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                switch (action)
                {
                    case "InsertSpace":
                        message = InsertSpace(int.Parse(arguments[1]), message);
                        break;
                    case "Reverse":
                        message = ReverseMessage(arguments[1], message);
                        break;
                    case "ChangeAll":
                        message = ChangeMessage(arguments[1], arguments[2], message);
                        break;

                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }

        static string InsertSpace(int index, string message)
        {
            message = message.Insert(index, " ");
            Console.WriteLine(message);
            return message;
        }

        static string ReverseMessage(string substring, string message)
        {
            if (message.Contains(substring))
            {
                // Намери индекса на подстринга
                int index = message.IndexOf(substring);
                // Изтрий подстринга и обърни го
                string reversed = new string(substring.Reverse().ToArray());
                // Добави обърнатия подстринг в края на съобщението
                message = message.Remove(index, substring.Length) + reversed;
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("error");
            }
            return message;
        }

        static string ChangeMessage(string substring, string replacement, string message)
        {
            if (message.Contains(substring))
            {
                message = message.Replace(substring, replacement);
            }
            Console.WriteLine(message);
            return message;
        }
    }
}

