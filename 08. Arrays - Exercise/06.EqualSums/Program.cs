int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
bool indexFound = false;
for (int i = 0; i < numbers.Length; i++)
{ 
    int leftSum = 0;
    if (i == 0)
    {
        leftSum = 0;
    }
    else
    {
        for (int j = i - 1; j >= 0; j--)
        {
            leftSum += numbers[j];
        }
    }
    int rightSum = 0;
    for (int j = i + 1; j < numbers.Length; j++)
    {
        rightSum += numbers[j];
    }
    if (leftSum == rightSum)
    { 
        indexFound = true;
        Console.WriteLine(i);
        break;
    }
}
if (!indexFound)
{
    Console.WriteLine("no");
}

