using System;
using System.Numerics;

int totalSnowballs = int.Parse(Console.ReadLine());
BigInteger bestBallValue = BigInteger.Zero;
int bestSnowballSnow = 0;
int bestSnowballTime = 0;
int bestSnowballQuality = 0;

for (int snowball = 1; snowball <= totalSnowballs; snowball++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    int snowCalculations = snowballSnow / snowballTime;
    BigInteger snowballValue = BigInteger.Pow(snowCalculations, snowballQuality);
    if (snowballValue > bestBallValue)
    {
        bestBallValue = snowballValue;
        bestSnowballSnow = snowballSnow;
        bestSnowballTime = snowballTime;
        bestSnowballQuality = snowballQuality;
    }
}
Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestBallValue} ({bestSnowballQuality})");
