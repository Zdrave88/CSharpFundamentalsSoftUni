int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

int wantedNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        //Console.WriteLine($"i = {i} which is: {numbers[i]}");
        //Console.WriteLine($"j = {j} which is: {numbers[j]}");
        if (numbers[i] + numbers[j] == wantedNumber)
        {
           // Console.WriteLine($"{numbers[i]} + {numbers[j]} = {wantedNumber}");
            Console.WriteLine($"{numbers[i]} {numbers[j]}");
        }
        //Console.WriteLine();
    }
}