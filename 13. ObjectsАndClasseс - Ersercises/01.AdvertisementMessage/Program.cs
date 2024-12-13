namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.",
                                 "I always use that product.", "Best product of its category.",
                                 "Exceptional product.", "I can't live without this product." };

            string[] events = { "Now I feel good.", "I have succeeded with this product.", 
                                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                                "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random randomText = new Random();

            int numberOfMassegesGenerated = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMassegesGenerated; i++)
            {

                // the method Next from class Random generate random number - index from 0 to [].Count-1/<>.Length-1 
                // generatinг number, index from 0 to  [].Count/<>.Length
                string phrase = phrases[randomText.Next(0, phrases.Length)];
                string eventText = events[randomText.Next(0, events.Length)];
                string author = authors[randomText.Next(0, authors.Length)];
                string city = cities[randomText.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {eventText} {author} – {city}.");
            }
            
        }
    }
}
