using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> collection = Console.ReadLine()
                                      .Split(" ")
                                      .ToList();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                if (action == "Change")
                {
                    string paintingNumber = (arguments[1]);
                    string newNumber = (arguments[2]);
                    if (collection.Contains(paintingNumber))
                    {
                        int index = collection.IndexOf(paintingNumber);
                        collection[index] = newNumber;
                    }
                }
                if (action == "Hide")
                {
                    string paintingNumber = (arguments[1]);
                    if (collection.Contains(paintingNumber))
                    {
                        collection.Remove(paintingNumber);
                    }
                }
                if (action == "Switch")
                {
                    string paintingNumber1 = (arguments[1]);
                    string paintingNumber2 = (arguments[2]);
                    if (collection.Contains(paintingNumber1) && collection.Contains(paintingNumber2))
                    {
                        int index1 = collection.IndexOf(paintingNumber1);
                        int index2 = collection.IndexOf(paintingNumber2);
                        collection.Insert(index1, paintingNumber2);
                        collection.Remove(paintingNumber1);
                        collection.Insert(index2, paintingNumber1);
                        collection.RemoveAt(index2 + 1);
                    }
                }
                if (action == "Insert")
                {
                    int index = int.Parse(arguments[1]);
                    string paintingNumber = (arguments[2]);
                    if (index >= 0 && index + 1 <= collection.Count)
                    {
                        collection.Insert(index + 1, paintingNumber);
                    }
                }
                if (action == "Reverse")
                {
                    collection.Reverse();
                }
            }
            Console.WriteLine(string.Join(" ", collection));
        }
    }
}
