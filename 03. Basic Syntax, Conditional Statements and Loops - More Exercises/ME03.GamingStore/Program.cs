double moneyBalance = double.Parse(Console.ReadLine());
double moneySpend = 0;
while (true)
{
    string command = Console.ReadLine();
    if (command == "Game Time")
    {
        break; ;
    }
    switch (command)
    {
        case "OutFall 4":
            if (moneyBalance >= 39.99)
            {
                Console.WriteLine("Bought OutFall 4");
                moneyBalance -= 39.99;
                moneySpend += 39.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        case "CS: OG":
            if (moneyBalance >= 15.99)
            {
                Console.WriteLine("Bought CS: OG");
                moneyBalance -= 15.99;
                moneySpend += 15.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        case "Zplinter Zell":
            if (moneyBalance >= 19.99)
            {
                Console.WriteLine("Bought Zplinter Zell");
                moneyBalance -= 19.99;
                moneySpend += 19.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        case "Honored 2":
            if (moneyBalance >= 59.99)
            {
                Console.WriteLine("Bought Honored 2");
                moneyBalance -= 59.99;
                moneySpend += 59.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        case "RoverWatch":
            if (moneyBalance >= 29.99)
            {
                Console.WriteLine("Bought RoverWatch");
                moneyBalance -= 29.99;
                moneySpend += 29.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        case "RoverWatch Origins Edition":
            if (moneyBalance >= 39.99)
            {
                Console.WriteLine("Bought RoverWatch Origins Edition");
                moneyBalance -= 39.99;
                moneySpend += 39.99;
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }
            if (moneyBalance <= 0.0)
            {
                Console.WriteLine($"Out of money!");
                return;
            }
            break;
        default: 
            Console.WriteLine("Not Found"); break;    
    }
  // command = Console.ReadLine();
}
Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${moneyBalance:f2}");

