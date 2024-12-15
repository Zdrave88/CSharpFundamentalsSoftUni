namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minerMap = new Dictionary<string, int>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int amount = int.Parse(Console.ReadLine());

                if (!minerMap.ContainsKey(resource))
                {
                    minerMap.Add(resource, amount);
                }
                else
                { 
                    minerMap[resource] += amount;
                }
            }
            foreach (KeyValuePair<string, int> pair in minerMap)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
