int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int maxNum2 = int.MinValue; 
int maxNum3 = int.MinValue; 

if (num1 > num2 && num1 > num3 && num1 > maxNum)
{
    maxNum = num1;
    if (num2 > num3)
    {
        maxNum2 = num2;
        maxNum3 = num3;
    }
    else
    {
        maxNum2 = num3;
        maxNum3 = num2;
    }
}
else if (num2 > num1 && num2 > num3 && num2 > maxNum)
{
    maxNum = num2;
    if (num1 > num3)
    {
        maxNum2 = num1;
        maxNum3 = num3;
    }
    else
    {
        maxNum2 = num3;
        maxNum3 = num1;
    }
}
else
{
    maxNum = num3;
    if (num2 > num1)
    {
        maxNum2 = num2;
        maxNum3 = num1;
    }
    else
    {
        maxNum2 = num1;
        maxNum3 = num2;
    }
}
Console.WriteLine($"{maxNum}\n{maxNum2}\n{maxNum3}");