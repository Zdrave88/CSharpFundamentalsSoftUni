using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number of dragons
            int numberOfDragons = int.Parse(Console.ReadLine());

            // Dictionary to store dragon types and their stats
            Dictionary<string, SortedDictionary<string, int[]>> dragonsByType = new Dictionary<string, SortedDictionary<string, int[]>>();

            // Default values
            const int defaultHealth = 250;
            const int defaultDamage = 45;
            const int defaultArmor = 10;

            for (int i = 0; i < numberOfDragons; i++)
            {
                // Read each dragon's data
                string[] dragonData = Console.ReadLine().Split();
                string dragonType = dragonData[0];
                string dragonName = dragonData[1];
                int damage = dragonData[2] != "null" ? int.Parse(dragonData[2]) : defaultDamage;
                int health = dragonData[3] != "null" ? int.Parse(dragonData[3]) : defaultHealth;
                int armor = dragonData[4] != "null" ? int.Parse(dragonData[4]) : defaultArmor;

                // Check if the dragon type already exists
                if (!dragonsByType.ContainsKey(dragonType))
                {
                    dragonsByType[dragonType] = new SortedDictionary<string, int[]>();
                }

                // Store or update the dragon's stats
                dragonsByType[dragonType][dragonName] = new int[] { damage, health, armor };
            }

            // Print results
            foreach (var dragonType in dragonsByType)
            {
                string type = dragonType.Key;
                var dragons = dragonType.Value;

                // Calculate averages
                double averageDamage = dragons.Values.Average(d => d[0]);
                double averageHealth = dragons.Values.Average(d => d[1]);
                double averageArmor = dragons.Values.Average(d => d[2]);

                // Print average stats
                Console.WriteLine($"{type}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})");

                // Print each dragon's stats
                foreach (var dragon in dragons)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
