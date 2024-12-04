int totalKegs = int.Parse(Console.ReadLine());
double biggestVolume = 0;
string bestKeg = string.Empty;
for (int keg = 1; keg <= totalKegs; keg++)
{
    string kegModel = Console.ReadLine();
    double kegRadius = double.Parse(Console.ReadLine());
    int kegHeight = int.Parse(Console.ReadLine());

    double volume = (Math.PI * (Math.Pow(kegRadius, 2)) * kegHeight);
    if (volume > biggestVolume)
    {
        biggestVolume = volume;
        bestKeg = kegModel;
    }
}
Console.WriteLine(bestKeg);