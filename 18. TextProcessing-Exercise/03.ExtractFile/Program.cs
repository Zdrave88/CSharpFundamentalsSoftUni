namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 0     1          2                3
            //// C:\Internal\training-internal\Template.pptx

            //// 0     1          2                3
            //// C:\Projects\Data-Structures\LinkedList.cs
            ///

            string[] input = Console.ReadLine().Split("\\");
            string lastElement = input[input.Length - 1];
            string lastElement2 = input[^1];

            string[] lastElementParts = lastElement2.Split(".");
            Console.WriteLine($"File name: {lastElementParts[0]}");
            Console.WriteLine($"File extension: {lastElementParts[1]}");

        }
    }
}
