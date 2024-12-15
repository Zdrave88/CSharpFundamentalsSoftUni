namespace demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> ordersMap = new Dictionary<string, double[]>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string product = arguments[0];
                double price = double.Parse(arguments[1]);
                double quantity = double.Parse(arguments[2]);

                if (!ordersMap.ContainsKey(product))
                {
                    ordersMap[product] = new double[2] { price, quantity };
                }
                else
                {
                    ordersMap[product][0] = price;
                    ordersMap[product][1] += quantity;
                }
                foreach (KeyValuePair<string, double[]> order in ordersMap)
                {
                    CalculatePrice(order.Key, order.Value);
                }
            }

            static void CalculatePrice(string product, double[] values)
            {
                double total = values[0] * values[1];
                Console.WriteLine($"{product} -> {total:f2}");
            }
        }
    }
}



            //foreach (KeyValuePair<string, double[]> order in ordersMap)
            //{
            //    double price = order.Value[0];
            //    double quantity = order.Value[1];
            //    double totalPrice = price * quantity;

            //    Console.WriteLine($"{order.Key} -> {totalPrice:f2}");
            //}
