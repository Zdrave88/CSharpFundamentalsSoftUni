int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    int leftSum = 0;
    for (int j = i - 1; j >= 0; j--)
    {
        leftSum += numbers[j];
    }

    int rightSum = 0;
    for (int k = i + 1; k < numbers.Length; k++)
    {
        rightSum += numbers[k];
    }
    if (leftSum == rightSum)
    {
        Console.WriteLine(numbers[i]);
    }
}