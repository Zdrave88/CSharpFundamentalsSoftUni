

namespace _04.ListОfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            PrintSortedProducts(count);
        }

        static string PrintSortedProducts(int count)
        {
            List<string> products = new ();
            for (int i = 0; i < count; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);  
            }
            products.Sort();

            int number = 1;
            foreach (string product in products)
            {
                Console.WriteLine($"{number}.{product}");
                number++;
            }
            return string.Join (", ", products);
        }
    }
}
