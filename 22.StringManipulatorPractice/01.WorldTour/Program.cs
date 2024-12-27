
namespace _01.WorldTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string[] arguments = command.Split(":");
                string action = arguments[0];
                switch (action)
                {
                    case "Add Stop":
                        map = AddStopToMap(int.Parse(arguments[1]), arguments[2], map);
                        break;
                    case "Remove Stop":
                        map = RemoveStopFromMap(int.Parse(arguments[1]), int.Parse(arguments[2]), map);
                        break;
                    case "Switch":
                        map = SwitchStopsInMap(arguments[1], arguments[2], map);
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {map}");
        }

        static string AddStopToMap(int index, string stop, string map)
        {
            if (index >= 0 && index <= map.Length)
            {
                map = map.Insert(index, stop);
            }
            Console.WriteLine(map);
            return map;
        }

        static string RemoveStopFromMap(int startIndex, int endIndex, string map)
        {
            if (startIndex >= 0 && startIndex <= endIndex && endIndex < map.Length)

            {
                map = map.Remove(startIndex, endIndex - startIndex + 1);
            }
            Console.WriteLine(map);
            return map;
        }
        static string SwitchStopsInMap(string substring, string replacement, string map)
        {
            if (map.Contains(substring))
            {
                map = map.Replace(substring, replacement);
            }
            Console.WriteLine(map);
            return map;
        }

    }
}
