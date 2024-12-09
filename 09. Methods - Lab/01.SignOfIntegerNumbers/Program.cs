using System;

internal class Program
{
    static void Main()
    {
        PrintNumberSign(int.Parse(Console.ReadLine()));
    }
    static void PrintNumberSign(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative. ");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}