int[] numbers = Console.ReadLine()
                   .Split(" ")
                   .Select(int.Parse)
                   .ToArray();

int[] numbers2 = Console.ReadLine()
                   .Split(" ")
                   .Select(int.Parse)
                   .ToArray();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == numbers2[i])
    {
        sum += numbers[i];
    }
    else
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        return;
    }
}
Console.WriteLine($"Arrays are identical. Sum: {sum}");