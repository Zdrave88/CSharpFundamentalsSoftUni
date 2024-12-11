
namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            Console.WriteLine(PrintGausseqSuence(numbers));
        }

        static string PrintGausseqSuence(List<int> numbers)
        {
            int count = numbers.Count;
            // hold the initial count, otherwise it will reduce the itteraction of the for loop due to  numbers.RemoveAt(numbers.Count - 1);

            for (int i = 0; i < count / 2; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            return string.Join(" ", numbers);
        }
    }
}