

namespace _05.AddAndSubtractt
{
    internal class Program
    {
        static void Main()
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());
            int sum = SumOfTwoNumbers(numA, numB);
            Console.WriteLine(SubstactionFromSumOfNumbers(sum, numC));
        }

        static int SubstactionFromSumOfNumbers(int sum, int numC)
        {
            int result = sum - numC;
            return result;
        }

        static int SumOfTwoNumbers(int number1, int number2)
        {

            return number1 + number2;
        }
    }
}
