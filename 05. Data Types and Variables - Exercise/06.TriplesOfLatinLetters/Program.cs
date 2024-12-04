int countsOfSymbolRepetition = int.Parse(Console.ReadLine());

for (int i = 0; i < countsOfSymbolRepetition; i++)
{
    for (int j = 0; j < countsOfSymbolRepetition; j++)
    {
        for (int k = 0; k < countsOfSymbolRepetition; k++)
        {
            char firstChar = (char)('a' + i);
            char secondChar = (char)('a' + j);
            char thirdChar = (char)('a' + k);
            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}

