using System;

namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(NumberPower(num, pow));
        }

        static double NumberPower(double num, double pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
