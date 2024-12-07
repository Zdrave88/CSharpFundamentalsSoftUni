int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool isTopInteger = true;
    for (int j = 1 + i; j < numbers.Length; j++)
    {
        // сравнявам дали числото от 1вия цикъл е <= на числото от 2рия цикъл
        if (numbers[i] <= numbers[j])
        {
            // ако числото от 2рия цикъл е по-голямо значи числото от 1вия цикъл НЕ Е TopInteger
            isTopInteger = false;
            break;
        }
    }
    //ако числото от 1вия цикъл е TopInteger го печатам
    if (isTopInteger)
    {
        Console.Write(numbers[i] + " ");
    }
}
