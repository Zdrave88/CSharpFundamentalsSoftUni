using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger factorialResult = 1;

            for (int i = 2; i <= number; i++)
            {
                factorialResult *= i;
            }
            Console.WriteLine(factorialResult);
        }
    }
}
