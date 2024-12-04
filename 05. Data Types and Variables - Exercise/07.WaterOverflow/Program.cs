int waterTankCapacity = 255;
int totalLitterPoured = 0;
int roundsOfPouring = int.Parse(Console.ReadLine());
for (int filling = 1; filling <= roundsOfPouring; filling++)
{
    
    int litersPoured = int.Parse(Console.ReadLine());

    totalLitterPoured += litersPoured;
    if (totalLitterPoured > waterTankCapacity)
    {
        Console.WriteLine($"Insufficient capacity!");
        totalLitterPoured -= litersPoured;
    }
}
Console.WriteLine(totalLitterPoured);