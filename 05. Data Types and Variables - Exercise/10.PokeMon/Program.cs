
//int pokePower = int.Parse(Console.ReadLine());
//int distance = int.Parse(Console.ReadLine());
//int exhaustionFactor = int.Parse(Console.ReadLine());
//double halfPower = pokePower / 2.0;

//int pokesCount = 0;
//while (pokePower >= distance)
//{
//    if (pokePower == halfPower)
//    {
//        pokePower /= exhaustionFactor;
//    }

//    if (pokePower > distance)
//    {
//        pokesCount++;
//        pokePower -= distance;
//    }
//}
//Console.WriteLine(pokePower);
//Console.WriteLine(pokesCount);




int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaustionFactor = int.Parse(Console.ReadLine());

double halfPower = power / 2.0;
int totalPokes = 0;

while (power >= distance)
{
    totalPokes++;
    power -= distance;

    if (halfPower == power && exhaustionFactor != 0)
    {
        power /= exhaustionFactor;
    }
}
Console.WriteLine(power);
Console.WriteLine(totalPokes);