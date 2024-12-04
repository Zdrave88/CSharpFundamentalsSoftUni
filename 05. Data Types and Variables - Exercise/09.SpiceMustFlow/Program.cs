int startingYield = int.Parse(Console.ReadLine());
int totalSpice = 0;
int daysOperated = 0;

while (startingYield >= 100)
{
    totalSpice += startingYield;
    startingYield -= 10;
    totalSpice -= 26;
    daysOperated++;
}


if (totalSpice >= 26)
{
    totalSpice -= 26;
}

Console.WriteLine(daysOperated);
Console.WriteLine(totalSpice);