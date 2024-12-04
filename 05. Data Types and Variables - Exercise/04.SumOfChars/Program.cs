//"The sum equals: {totalSum}"

int totalLines = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < totalLines; i++)
{
    char symbol = char.Parse(Console.ReadLine());
    sum += (int)symbol;
}
Console.WriteLine($"The sum equals: {sum}");