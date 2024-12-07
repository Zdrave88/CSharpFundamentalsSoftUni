
// Четене на дължината на ДНК последователностите
int sequenceLength = int.Parse(Console.ReadLine());

string input;
int bestLength = 0;
int bestIndex = 0;
int bestSum = 0;
int bestSequenceIndex = 0;
int currentSequenceIndex = 0;
int[] bestSequence = new int[sequenceLength];

while ((input = Console.ReadLine()) != "Clone them!")
{
    // Увеличаване на индекса на текущата последователност
    currentSequenceIndex++;

    // Преобразуване на входната последователност в масив от числа
    int[] currentSequence = input
        .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    // Търсене на най-дългата поредица от 1-ци в текущата последователност
    int currentBestLength = 0;
    int currentBestIndex = 0;
    int currentLength = 0;
    int currentSum = currentSequence.Sum();

    for (int i = 0; i < currentSequence.Length; i++)
    {
        if (currentSequence[i] == 1)
        {
            currentLength++;

            if (currentLength > currentBestLength)
            {
                currentBestLength = currentLength;
                currentBestIndex = i - currentLength + 1;
            }
        }
        else
        {
            currentLength = 0;
        }
    }

    // Проверка дали текущата последователност е по-добра от най-добрата досега
    if (currentBestLength > bestLength ||
        (currentBestLength == bestLength && currentBestIndex < bestIndex) ||
        (currentBestLength == bestLength && currentBestIndex == bestIndex && currentSum > bestSum))
    {
        bestLength = currentBestLength;
        bestIndex = currentBestIndex;
        bestSum = currentSum;
        bestSequenceIndex = currentSequenceIndex;
        bestSequence = currentSequence;
    }
}

// Извеждане на резултата за най-добрата последователност
Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestSequence));
