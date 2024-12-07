﻿double[] numbers = Console.ReadLine()
                   .Split(" ")
                   .Select(double.Parse)
                   .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 0 || numbers[i] == -0)
    {
        Console.WriteLine($"{numbers[i]} => {(int)Math.Abs(Math.Round(numbers[i], MidpointRounding.AwayFromZero))}");
    }
    else
    {
        Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
    }
}