int[] numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
int bestLength = 1;       // Най-дълга поредица
int currentLength = 1;    // Текуща дължина на поредицата
int bestIndex = numbers[0];  // Число с най-дълга поредица
for (int i = 0; i < numbers.Length - 1; i++)
{
    if (numbers[i] == numbers[i + 1])
    {
        currentLength++;
    }
    else
    {
        currentLength = 1;
    }
    // Ако намерим нова най-дълга поредица
    if (currentLength > bestLength)
    {
        bestLength = currentLength;
        bestIndex = numbers[i];
    }
}
// Отпечатване на числото, повторено най-дългия брой пъти
for (int i = 0; i < bestLength; i++)
{
    Console.Write(bestIndex + " ");
}
