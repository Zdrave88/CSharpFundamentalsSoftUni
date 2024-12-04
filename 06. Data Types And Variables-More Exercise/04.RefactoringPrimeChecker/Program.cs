int finalNumber = int.Parse(Console.ReadLine());

for (int number = 2; number <= finalNumber; number++)
{
    bool isPrime = true;
    for (int devider = 2; devider < number; devider++)
    {
        if (number % devider == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine($"{number} -> true");
    }
    else
    {
        isPrime = false;
        Console.WriteLine($"{number} -> false");
    }
}