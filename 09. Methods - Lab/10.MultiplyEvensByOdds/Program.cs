namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int number = Math.Abs(numberInput);
            //Console.WriteLine(GetSumOfEvenDigits(number));
            //Console.WriteLine(GetSumOfOddDigits(number));
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum));
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
            int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {

            return evenSum * oddSum;
        }
    }
}
