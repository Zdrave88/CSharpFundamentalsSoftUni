string[] symbols = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

string[] reversed = new string[symbols.Length];
for (int i = symbols.Length - 1; i >= 0; i--)
{
    reversed[i] = symbols[symbols.Length - 1 - i]; 
}
Console.WriteLine(string.Join(" ", reversed));