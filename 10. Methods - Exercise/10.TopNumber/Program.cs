using System;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopIntegers(number);
        }

        static void PrintTopIntegers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDivisibleByEight(i) && NumberGotOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool NumberGotOneOddDigit(int number)
        {
            int tempNum = number;
            while (tempNum > 0)
            {
                int digit = tempNum % 10;
                if (digit % 2 != 0) // Проверка за нечетна цифра
                {
                    return true; // Връща true веднага, ако намери нечетна цифра
                }
                tempNum /= 10;
            }
            return false; // Връща false, ако няма нечетни цифри
        }

        static bool IsDivisibleByEight(int number)
        {
            int tempNum = number;
            int sum = 0;
            while (tempNum > 0)
            {
                sum += tempNum % 10;
                tempNum /= 10;
            }
            return sum % 8 == 0; // Връща true, ако сумата е кратна на 8
        }
    }
}
