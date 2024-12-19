using System;
using System.Collections.Generic;
using System.Linq;

namespace GoogleEarningsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Romance | Fiction | Horror | Mystery
            List<string> collection = Console.ReadLine().Split(" | ").ToList();
            string command;

            while ((command = Console.ReadLine()) != "Stop!")
            {
                string[] arguments = command.Split(" ");
                string action = arguments[0];
                if (action == "Join")
                {
                    string genre = arguments[1];
                    if (!collection.Contains(genre))
                    {
                        collection.Add(genre);
                    }
                }
                else if (action == "Drop")
                {
                    string genre = arguments[1];
                    if (collection.Contains(genre))
                    {
                        collection.Remove(genre);
                    }
                }
                else if (action == "Replace")
                {
                    string oldGenre = arguments[1];
                    string newGenre = arguments[2];
                    if (collection.Contains(oldGenre) && !collection.Contains(newGenre))
                    {
                        int index = collection.IndexOf(oldGenre);
                        collection.Insert(index, newGenre);
                        collection.Remove(oldGenre);
                    }
                }
                else if (action == "Prefer")
                {
                    int index1 = int.Parse(arguments[1]);
                    int index2 = int.Parse(arguments[2]);
                    if (index1 < 0 || index1 > collection.Count - 1 || index2 < 0 || index2 > collection.Count - 1)
                    {
                        //Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        string temp = collection[index1];
                        collection[index1] = collection[index2];
                        collection[index2] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
