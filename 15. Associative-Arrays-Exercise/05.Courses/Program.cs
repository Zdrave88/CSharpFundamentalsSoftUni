namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesMap = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] coursesInfo = input.Split(" : ");
                string courseName = coursesInfo[0];
                string studentName = coursesInfo[1];

                if (!coursesMap.ContainsKey(courseName))            // THE COURSE IS NOT EXISTING
                {
                    coursesMap.Add(courseName, new List<string>()); // CREATING THE COURSE-KEY, CREATING A LIST-VALUE
                }

                coursesMap[courseName].Add(studentName);            // THE COURSE ALREADY EXIST - JUST ADDING INFO TO THE VALUE/LIST 
            }


            foreach (KeyValuePair<string, List<string>> pair in coursesMap)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");    // pair.Value.Count gives the amount of elements in the list/value section
                foreach (var student in pair.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
