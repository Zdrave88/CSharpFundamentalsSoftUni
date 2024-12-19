namespace _01.TheBiscuitFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int factoryWorkers = int.Parse(Console.ReadLine());
            int biscuitsCompetingFactory = int.Parse(Console.ReadLine());

            int month = 30;
            double totalBiscuitsMade = 0;

            for (int day = 1; day <= month; day++)
            {
                if (day % 3 == 0)
                {
                    totalBiscuitsMade += (int)Math.Floor((biscuitsPerWorker * factoryWorkers) * 0.75);
                }
                else
                {
                    totalBiscuitsMade += biscuitsPerWorker * factoryWorkers;
                }
            }
            Console.WriteLine($"You have produced {totalBiscuitsMade} biscuits for the past month.");

            if (totalBiscuitsMade > biscuitsCompetingFactory)
            {
                double difference = (Math.Abs(totalBiscuitsMade - biscuitsCompetingFactory));
                double differenceInPercentages = (difference / biscuitsCompetingFactory) * 100;
                Console.WriteLine($"You produce {differenceInPercentages:f2} percent more biscuits.");
            }
            else
            {
                double difference = (Math.Abs(totalBiscuitsMade - biscuitsCompetingFactory));
                double differenceInPercentages = (difference / biscuitsCompetingFactory) * 100;
                Console.WriteLine($"You produce {differenceInPercentages:f2} percent less biscuits.");
            }
        }
    }
}
