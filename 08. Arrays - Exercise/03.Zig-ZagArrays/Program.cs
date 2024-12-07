int length = int.Parse(Console.ReadLine());
int[] arrayOne = new int[length];
int[] arrayTwo = new int[length];

for (int i = 0; i < length; i++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        arrayOne [i] = numbers [0];
        arrayTwo [i] = numbers [1];
    }
    else
    {
        arrayTwo[i] = numbers[0];
        arrayOne [i] = numbers [1];
    }
}
Console.WriteLine(string.Join(" ", arrayOne));
Console.WriteLine(string.Join(" ", arrayTwo));


/*
 
 int numberOfPairs = int.Parse(Console.ReadLine());
int[] arrayOne = new int[numberOfPairs];
int[] arrayTwo = new int[numberOfPairs];

for (int i = 0; i < numberOfPairs; i++)
{
    int[] added = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
    if (i % 2 == 0)
    {
        arrayOne[0 + i] = added[0]; 
        arrayTwo[0 + i] = added[1];
    }
    else
    { 
        arrayOne [0 + i] = added[1];
        arrayTwo [0 + i] = added[0];
    }
}
Console.WriteLine(string.Join(" ", arrayOne));
Console.WriteLine(string.Join(" ", arrayTwo));

 */