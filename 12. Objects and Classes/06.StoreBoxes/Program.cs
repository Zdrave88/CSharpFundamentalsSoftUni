using System.Security.Cryptography.X509Certificates;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ");

                string serialNumber = input[0];
                string itemNames = input[1];
                int itemQuantity = int.Parse(input[2]);
                decimal itemPrice = decimal.Parse(input[3]);

                Item item = new Item
                { 
                    Name = itemNames,
                    Price = itemPrice,
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PricePerBox = itemQuantity * itemPrice
                };
                boxes.Add(box);
            }
            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PricePerBox { get; set; }
    }
}
class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
