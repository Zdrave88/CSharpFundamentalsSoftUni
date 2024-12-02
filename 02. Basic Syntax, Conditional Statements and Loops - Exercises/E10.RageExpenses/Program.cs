int lostGames = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

double totalCost = 0;
int keyboardCrashed = 0;

for (int game = 1; game <= lostGames; game++)
{
    if (game % 2 == 0)
    {
        totalCost += headsetPrice;
    }
    if (game % 3 == 0)
    {
        totalCost += mousePrice;
    }
    if (game % 2 == 0 && game % 3 == 0)
    {
        totalCost += keyboardPrice;
        keyboardCrashed++;
        if (keyboardCrashed % 2 == 0)
        {
            totalCost += displayPrice;
        }
    }
}
Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");













