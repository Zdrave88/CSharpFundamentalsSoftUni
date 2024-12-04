int totalLines = int.Parse(Console.ReadLine());

for (int line = 1; line <= totalLines; line++)
{
    string[] numbers = Console.ReadLine().Split(' ');
    long leftNumber = long.Parse(numbers[0]);
    long rightNumber = long.Parse(numbers[1]);

    if (leftNumber > rightNumber)
    {
        long leftSum = 0;
        leftNumber = Math.Abs(leftNumber);
        while (leftNumber > 0)
        {
            leftSum += leftNumber % 10;
            leftNumber /= 10;
        }
        Console.WriteLine(leftSum);
    }
    else
    {
        long rightSum = 0;
        rightNumber = Math.Abs(rightNumber);
        while (rightNumber > 0)
        {
            rightSum += rightNumber % 10;
            rightNumber /= 10;
        }
        Console.WriteLine($"{rightSum}");
    }
}