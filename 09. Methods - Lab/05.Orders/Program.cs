using System.Diagnostics;

namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            PrintOrderPrice(product, amount);
            
        }
        static void PrintOrderPrice(string product, int amount)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
            }
            double money = price * amount;
            Console.WriteLine($"{money:f2}");
        }
    }
}
