decimal num1 = decimal.Parse(Console.ReadLine());
decimal num2 = decimal.Parse(Console.ReadLine());
const decimal eps = 0.000001m;

decimal result = 0;
if (num1 > num2)
{
    result = num1 - num2;
}
else
{
    result = num2 - num1;
}

bool isBigger = false;
if (result < eps)
{
    isBigger = true;
    Console.WriteLine(isBigger);
}
else
{ 
    Console.WriteLine(isBigger);
}