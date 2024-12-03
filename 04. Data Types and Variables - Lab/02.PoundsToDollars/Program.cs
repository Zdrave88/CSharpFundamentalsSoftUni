//1 British Pound = 1.31 Dollars

double dollarRate = 1.31;

double britishPountInput = double.Parse(Console.ReadLine());

double preciseAmount = britishPountInput * dollarRate;

Console.WriteLine($"{preciseAmount:f3}");