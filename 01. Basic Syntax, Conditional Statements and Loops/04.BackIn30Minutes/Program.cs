int hour = int.Parse(Console.ReadLine());
int minute = int.Parse(Console.ReadLine());
int minutePlus30 = minute + 30;

if (minutePlus30 > 59)
{
    hour++;
    minutePlus30 -= 60;
    if (hour > 23)
    {
        hour = 00;
    }
}
if (minutePlus30 < 10)
{
    Console.WriteLine($"{hour}:0{minutePlus30}");
}
else
{
    Console.WriteLine($"{hour}:{minutePlus30}");
}



















