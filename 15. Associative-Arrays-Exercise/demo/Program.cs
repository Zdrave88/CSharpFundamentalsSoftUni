using System.Windows.Markup;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyMap = new();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeID = arguments[1];

                // CHECK IF KEY EXIST 
                if (!companyMap.ContainsKey(companyName))          
                {
                    // CREATE KEY IF NOT
                    companyMap[companyName] = new List<string>();
                }

                // CHECK IF VALUE ALREADY EXIST
                if (!companyMap[companyName].Contains(employeeID))
                {
                    // CREATE VALUE IF NOT 
                    companyMap[companyName].Add(employeeID);
                }
            }
            foreach (KeyValuePair<string, List<string>> pair in companyMap)
            {
                Console.WriteLine(pair.Key);
                foreach (string value in pair.Value)
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
