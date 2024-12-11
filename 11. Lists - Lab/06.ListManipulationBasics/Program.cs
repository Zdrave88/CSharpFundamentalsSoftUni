


using System.Net.Sockets;

namespace demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            PrintManipulatedList(numbers);
        }

        static void PrintManipulatedList(List<int> numbers)
        {
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
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
