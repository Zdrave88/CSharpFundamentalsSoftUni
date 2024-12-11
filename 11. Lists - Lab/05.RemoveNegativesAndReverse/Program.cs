
namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            Console.WriteLine(PrintPositiveNumber(numbers));
        }

        static string PrintPositiveNumber(List<int> numbers)
        {
            List<string> positiveNumbers = new List<string>();
            foreach (int number in numbers)
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number.ToString());
                }
            }
            positiveNumbers.Reverse();
            if (positiveNumbers.Count <= 0)
            {
                {
                    return "empty";
                }
            }
            return string.Join(" ", positiveNumbers);
        }
    }
}
