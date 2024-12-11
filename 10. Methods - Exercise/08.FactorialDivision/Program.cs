

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result1 = CalculateFirstFactorial(num1);
            double result2 = CalculateSecondFactorial(num2);
            Console.WriteLine($"{CalculateFinalResult(result1, result2):f2}");
        }

        static double CalculateFinalResult(double result1,double result2)
        {
            return result1 / result2;
        }

        static double CalculateFirstFactorial(double num1)
        {
            double result = 1;
            while (num1 > 0)
            {
                result *= num1;
                num1--;
            }
            return result;
        }
        static double CalculateSecondFactorial(double num2)
        {
            double result = 1;
            while (num2 > 0)
            {
                result *= num2;
                num2--;
            }
            return result;
        }
    }
}
