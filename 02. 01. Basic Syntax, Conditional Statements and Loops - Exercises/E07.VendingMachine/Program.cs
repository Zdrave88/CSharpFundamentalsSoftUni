double nuts = 2.0;
double water = 0.7;
double crisps = 1.5;
double soda = 0.8;
double coke = 1.0;
double moneyToSpend = 0;

string action = Console.ReadLine();

while (action != "Start")
{
    double coin = double.Parse(action);
    if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
    {
        moneyToSpend += coin;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coin}");
    }
    action = Console.ReadLine();
}

//Console.WriteLine($"You have {moneyToSpend:f2} ");

string product = Console.ReadLine();
while (product != "End")
{
    switch (product)
    {
        case "Nuts":
            if (moneyToSpend >= nuts)
            {
                moneyToSpend -= nuts; Console.WriteLine($"Purchased nuts");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Water":
            if (moneyToSpend >= water)
            {
                moneyToSpend -= water; Console.WriteLine($"Purchased water");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Crisps":
            if (moneyToSpend >= crisps)
            {
                moneyToSpend -= crisps; Console.WriteLine($"Purchased crisps");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Soda":
            if (moneyToSpend >= soda)
            {
                moneyToSpend -= soda; Console.WriteLine($"Purchased soda");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
        case "Coke":
            if (moneyToSpend >= coke)
            {
                moneyToSpend -= coke; Console.WriteLine($"Purchased coke");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
            }
            break;
            default: Console.WriteLine("Invalid product"); break;
    }
    product = Console.ReadLine();
}
Console.WriteLine($"Change: {moneyToSpend:f2}");