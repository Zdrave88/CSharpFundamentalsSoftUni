//using System.Threading.Channels;

//namespace _01.TheImitationGame
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string textInput = Console.ReadLine();
//            string command;

//            while ((command = Console.ReadLine()) != "Decode")
//            {
//                string[] arguments = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
//                string action = arguments[0];
//                if (action == "Move")
//                {
//                    // textInput == Zdravko
//                    int numberOfLetters = int.Parse(arguments[1]);                      // 3
//                    string substring = textInput.Substring(0, numberOfLetters);         // Zdr
//                    textInput = textInput.Remove(0, numberOfLetters);                   // avko
//                    textInput += substring;                                             // avkoZdr
//                }
//                else if (action == "Insert")
//                {
//                    // textInput == Zdravko
//                    int indexToInsert = int.Parse(arguments[1]);                        // 4
//                    string valueToInsert = arguments[2];                                // BAMBUCHA
//                    textInput = textInput.Insert(indexToInsert, valueToInsert);         // ZdraBAMBUCHAvko
//                }
//                else if (action == "ChangeAll")
//                {
//                    // textInput == Zdravko
//                    string valueToSubstring = arguments[1];                             // avko
//                    string valueToReplace = arguments[2];                               // avun
//                    textInput = textInput.Replace(valueToSubstring, valueToReplace);    // Zdravun
//                }
//            }
//            Console.WriteLine($"The decrypted message is: {textInput}");
//        }
//    }
//}


// METHODS


using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string message = Console.ReadLine();
                string command;

                while ((command = Console.ReadLine()) != "Decode")
                {
                    string[] arguments = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    string action = arguments[0];
                    switch (action)
                    {
                        case "Move":
                            message = MoveMessage(int.Parse(arguments[1]), message);
                            break;
                        case "Insert":
                            message = ChangeMessage(int.Parse(arguments[1]), arguments[2], message);
                            break;
                        case "ChangeAll":
                            message = ReplaceMessage(arguments[1], arguments[2], message);
                            break;
                    }
                }
                Console.WriteLine($"The decrypted message is: {message}");
            }

            static string MoveMessage(int numberOfLetters, string message)
            {
                string letters = message.Substring(0, numberOfLetters);
                message = message.Remove(0, numberOfLetters);
                message = message.Insert(message.Length, letters);
                //message += letters;
                //Console.WriteLine(message);
                return message;
            }

            static string ChangeMessage(int index, string value, string message)
            {
                message = message.Insert(index, value);
                //Console.WriteLine(message);
                return message;
            }

            static string ReplaceMessage(string substring, string replacement, string message)
            {
                if (message.Contains(substring))
                {
                    message = message.Replace(substring, replacement);
                }
                //Console.WriteLine(message);
                return message;
            }
        }

    }
}
