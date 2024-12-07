int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse) 
                .ToArray();

int totalRotations = int.Parse(Console.ReadLine());

for (int rotation = 0; rotation < totalRotations; rotation++)
{
    int firstElement = numbers[0];

    for (int i = 0; i < numbers.Length -1; i++)
    {
        numbers[i] = numbers[i + 1];
    }

    numbers[numbers.Length-1] = firstElement;
}

Console.WriteLine(string.Join(" ", numbers));