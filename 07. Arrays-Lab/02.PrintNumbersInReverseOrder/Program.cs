int length = int.Parse(Console.ReadLine());
int[] numbers = new int[length];

for (int i = 0; i < numbers.Length; i++)
{
    int addedNumber = int.Parse(Console.ReadLine());
    numbers[i] = addedNumber;
}
int[] reversedArray = new int[length];
for (int i = numbers.Length - 1; i >= 0; i--)
{
    reversedArray[i] = numbers[numbers.Length - 1 - i];
}

foreach (int i in reversedArray)
{
    Console.Write(i + " ");
}

//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{numbers[i]} ");
//}
//for (int i = numbers.Length - 1; i >= 0; i--)
//{
//    Console.Write($"{numbers[i]} ");
//}


















