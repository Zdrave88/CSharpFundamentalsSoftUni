/* •	Reduce the span of the variables by declaring them at the moment they receive a value, not before.
   •    Rename your variables to represent their real purpose (example: "isSpecialNum" should become isSpecialNum, etc.).
   •	Search for variables that have multiple purposes. If you find any, introduce a new variable.*/






int end = int.Parse(Console.ReadLine());
for (int number = 1; number <= end; number++)
{
    int sum = 0;
    int numberCopy = number;

    while (numberCopy > 0)
    {
        sum += numberCopy % 10;
        numberCopy = numberCopy / 10;
    }
    bool isSpecialNum = false;
    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecialNum = true;
        Console.WriteLine($"{number} -> {isSpecialNum}");
    }
    else
    {
        Console.WriteLine($"{number} -> {isSpecialNum}");
    }
}













//bool isSpecial = false;

//int end = int.Parse(Console.ReadLine());
//int sum = 0;

//for (int number = 1; number <= end; number++)
//{
//    int digit = number % 10;
//    sum += digit;
//    digit = number / 10;
//    sum += digit;
//    if (sum == 5 || sum == 7 || sum == 11)
//    {
//        isSpecial = true;
//        Console.WriteLine($"{number} -> {isSpecial}");
//    }
//    else
//    {
//        isSpecial = false;
//        Console.WriteLine($"{number} -> {isSpecial}");
//    }
//    sum = 0;
//}
