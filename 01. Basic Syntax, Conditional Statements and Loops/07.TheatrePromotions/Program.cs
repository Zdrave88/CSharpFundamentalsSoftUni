﻿string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;
if (day == "Weekday")
{
    if (age >= 0 && age <= 18)
    {
        price = 12;
        Console.WriteLine($"{price}$");
    }
    else if (age > 18 && age <= 64)
    {
        price = 18;
        Console.WriteLine($"{price}$");
    }
    else if (age > 64 && age <= 122)
    {
        price = 12;
        Console.WriteLine($"{price}$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else if (day == "Weekend")
{
    if (age >= 0 && age <= 18)
    {
        price = 15;
        Console.WriteLine($"{price}$");
    }
    else if (age > 18 && age <= 64)
    {
        price = 20;
        Console.WriteLine($"{price}$");
    }
    else if (age > 64 && age <= 122)
    {
        price = 15;
        Console.WriteLine($"{price}$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}
else
{
    if (age >= 0 && age <= 18)
    {
        price = 5;
        Console.WriteLine($"{price}$");
    }
    else if (age > 18 && age <= 64)
    {
        price = 12;
        Console.WriteLine($"{price}$");
    }
    else if (age > 64 && age <= 122)
    {
        price = 10;
        Console.WriteLine($"{price}$");
    }
    else
    {
        Console.WriteLine("Error!");
    }
}