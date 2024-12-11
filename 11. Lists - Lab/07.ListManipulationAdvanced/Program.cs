using System;
using System.Linq;
using System.Net.Sockets;

namespace demo02
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            PrintManipulatedList(numbers);
        }

        static void PrintManipulatedList(List<int> numbers)
        {
            int changes = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                string action = arguments[0];

                // ADD SECTION
                if (action == "Add")
                {
                    int number = int.Parse(arguments[1]);
                    numbers.Add(number);
                }

                // REMOVE SECTION
                else if (action == "Remove")
                {
                    int number = int.Parse(arguments[1]);
                    numbers.Remove(number);
                }

                // REMOVEAT SECTION
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(arguments[1]);
                    numbers.RemoveAt(index);
                }

                // INSERT SECTION
                else if (action == "Insert")
                {
                    int index = int.Parse(arguments[2]);
                    int number = int.Parse(arguments[1]);
                    numbers.Insert(index, number);
                }

                // CONTAINS SECTION
                else if (action == "Contains")
                {
                    int number = int.Parse((arguments[1]));
                    bool containsNumber = numbers.Contains(number);
                    if (containsNumber)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }

                // PRINT EVEN SECTION 
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = new();
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                            evenNumbers.Add(number);
                    }
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }

                // PRINT ODD SECTION
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = new();
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                            oddNumbers.Add(number);
                    }
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }

                // GET SUM SECTION
                else if (action == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }

                // FILTER SECTION
                else if (action == "Filter")
                {
                    string condition = arguments[1];
                    int number = int.Parse((arguments[2]));
                    List<int> filteredNumbers = new();
                    switch (condition)
                    {

                        case ">=":
                            foreach (int n in numbers)
                            {
                                if (n >= number)
                                {
                                    filteredNumbers.Add(n);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredNumbers));
                            break;

                        case "<=":
                            foreach (int n in numbers)
                            {
                                if (n <= number)
                                {
                                    filteredNumbers.Add(n);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredNumbers));
                            break;


                        case ">":
                            foreach (int n in numbers)
                            {
                                if (n > number)
                                {
                                    filteredNumbers.Add(n);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredNumbers));
                            break;

                        case "<":
                            foreach (int n in numbers)
                            {
                                if (n < number)
                                {
                                    filteredNumbers.Add(n);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredNumbers));
                            break;
                    }
                }

                if (action == "Add" || action == "Remove" || action == "RemoveAt" || action == "Insert")
                {
                    changes++;
                }
            }
            if (changes > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
