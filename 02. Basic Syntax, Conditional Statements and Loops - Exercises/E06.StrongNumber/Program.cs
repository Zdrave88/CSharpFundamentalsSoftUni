int number = int.Parse(Console.ReadLine());

int copy = number;
int factorialSum = 0;

while (copy > 0)
{
    int lastDigit = copy % 10;
    copy /= 10;

    int factorial = 1;
    for (int i = 1; i <= lastDigit; i++)
    {
        factorial *= i;
    }

    factorialSum += factorial;
}
if (number == factorialSum)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}