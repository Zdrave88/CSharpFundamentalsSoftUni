
bool isSpecial = false;

int end = int.Parse(Console.ReadLine());
int sum = 0;

for (int number = 1; number <= end; number++)
{
    int digit = number % 10;
    sum += digit;
    digit = number / 10;
    sum += digit;
    if (sum == 5 || sum == 7 || sum == 11)
    {
        isSpecial = true;
        Console.WriteLine($"{number} -> {isSpecial}");
    }
    else
    {
        isSpecial = false;
        Console.WriteLine($"{number} -> {isSpecial}");
    }
    sum = 0;
}




//int count = int.Parse(Console.ReadLine());
//for (int i = 1; i <= count; i++)
//{
//    int sum = 0;
//    int currentNum = i;

//    while (currentNum != 0)
//    {
//        sum += currentNum % 10;
//        currentNum = currentNum / 10;

//        //124 - special number with sum == 7
//        //124 % 10 = 4
//        //124 / 10 = 12
//        //sum = 4

//        //12 % 10 = 2
//        //12 / 10  = 1
//        //sum = 4 + 2

//        // 1 % 10 = 1
//        // 1 / 10 = 0
//        //sum = 4 + 2 + 1

//    }

//    if (sum == 5 || sum == 7 || sum == 11)
//    {
//        Console.WriteLine($"{i} -> True");
//    }
//    else
//    {
//        Console.WriteLine($"{i} -> False");
//    }
//}