int collumns = int.Parse(Console.ReadLine());

for (int rows = 1; rows <= collumns; rows++)
{
    for (int j = 1; j <= rows; j++)
    {
        Console.Write($"{rows} ");
    }
    Console.WriteLine();
}