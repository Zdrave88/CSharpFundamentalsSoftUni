using System;
using System.Collections.Generic;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                bool isValid = true;
                foreach (char symbol in username)
                {
                    if (!char.IsLetterOrDigit(symbol) && symbol != '-' && symbol != '_')
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid == true)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
