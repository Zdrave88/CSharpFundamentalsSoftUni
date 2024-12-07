int[] numbers = new int[20];
int multiplayer = 5;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = i;
    numbers[i] *= multiplayer;
}
Console.WriteLine(string.Join(" ", numbers));