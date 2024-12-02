int totalOrders = int.Parse(Console.ReadLine());
double totalCost = 0;
for (int order = 1; order <= totalOrders; order++)
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int daysInMonth = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double orderCost = (daysInMonth * capsulesCount) * capsulePrice;
    Console.WriteLine($"The price for the coffee is: ${orderCost:f2}");
    totalCost += orderCost;
}

Console.WriteLine($"Total: ${totalCost:f2}");