int givenNumber = int.Parse(Console.ReadLine());

if (givenNumber % 10 == 0)
{
    Console.WriteLine($"The number is divisible by 10");
    return;
}
else if (givenNumber % 7 == 0)
{
    Console.WriteLine($"The number is divisible by 7");
    return;
}
else if (givenNumber % 6 == 0)
{
    Console.WriteLine($"The number is divisible by 6");
    return;
}
else if (givenNumber % 3 == 0)
{
    Console.WriteLine($"The number is divisible by 3");
    return;
}
else if (givenNumber % 2 == 0)
{
    Console.WriteLine($"The number is divisible by 2");
    return;
}
else
{
    Console.WriteLine("Not divisible");
}