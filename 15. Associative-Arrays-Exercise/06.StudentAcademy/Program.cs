namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentMap = new Dictionary<string, List<double>>();

            int totalPairs = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalPairs; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentMap.ContainsKey(studentName))
                {
                    studentMap[studentName] = new List<double>();
                }
                studentMap[studentName].Add(studentGrade);
            }

            studentMap
              .Where(pair => pair.Value.Average() >= 4.50)
              .ToList()
              .ForEach(pair => Console.WriteLine($"{pair.Key} -> {pair.Value.Average():f2}"));


            //foreach (KeyValuePair<string, List<double>> pair in studentMap)
            //{
            //    string studentName = pair.Key;

            //    double totalGrade = 0;
            //    foreach (double grade in pair.Value)
            //    {
            //        totalGrade += grade;
            //    }
            //    double average = totalGrade / pair.Value.Count;
            //    if (average >= 4.50)
            //    {
            //        Console.WriteLine($"{studentName} -> {average:f2}");
            //    }


        }
    }
}


