using System.Xml.Linq;

namespace _02.FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                                .Split(",")
                                .ToList();

            string command;
            int totalBlacklistedNames = 0;
            int totalLostNames = 0;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] arguments = command.Split();
                string action = arguments[0];
                if (action == "Blacklist")
                {
                    string name = arguments[1];
                    int index = names.IndexOf(name);
                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {

                        Console.WriteLine($"{name} was blacklisted");
                        names[index] = "Blacklisted";
                        totalBlacklistedNames++;
                    }
                }
                else if (action == "Error")
                {
                    int index = int.Parse(arguments[1]);
                    if (index < 0 || index > names.Count -1)
                    {
                        continue;
                    }
                    else if (names[index] != "Blacklisted" && names[index] != "Lost")
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names[index] = "Lost"; 
                        totalLostNames++; 
                    }
                }
                else if (action == "Change")
                {
                    int index = int.Parse(arguments[1]);
                    string newName = arguments[2];
                    if (index < 0 || index > names.Count - 1)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{names[index]} changed his username to {newName}.");
                        names[index] = newName;
                    }
                }
            }
            Console.WriteLine($"Blacklisted names: {totalBlacklistedNames}");
            Console.WriteLine($"Lost names: {totalLostNames}");
            Console.WriteLine(string.Join(" ",names));
        }
    }
}
