namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCommand = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingMap = new Dictionary<string, string>();

            for (int i = 0; i < totalCommand; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                switch (command)
                {
                    case "register":
                        string usernameToAdd = input[1];
                        string licensePlate = input[2];
                        if (!parkingMap.ContainsKey(usernameToAdd))
                        {
                            parkingMap.Add(usernameToAdd, licensePlate);
                            Console.WriteLine($"{usernameToAdd} registered {licensePlate} successfully");
                        }
                        else if (parkingMap.ContainsValue(licensePlate))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;

                    case "unregister":
                        string usernameToRemove = input[1];
                        if (!parkingMap.ContainsKey(usernameToRemove))
                        {
                            Console.WriteLine($"ERROR: user {usernameToRemove} not found");
                        }
                        else if (parkingMap.ContainsKey(usernameToRemove))
                        {
                            Console.WriteLine($"{usernameToRemove} unregistered successfully");
                        }
                        break;

                }

            }
            foreach (KeyValuePair<string, string> pair in parkingMap)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}

