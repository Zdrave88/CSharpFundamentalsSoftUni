namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = input.Split(':');
                string contest = contestInfo[0];
                string password = contestInfo[1];
                contests[contest] = password;
            }

            // Речник за студентите и точките им в състезанията
            Dictionary<string, Dictionary<string, int>> students = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionInfo = input.Split("=>");
                string contest = submissionInfo[0];
                string password = submissionInfo[1];
                string username = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);

                // Проверка дали състезанието и паролата са валидни
                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    // Добавяне на студента към речника, ако липсва
                    if (!students.ContainsKey(username))
                    {
                        students[username] = new Dictionary<string, int>();
                    }

                    // Добавяне на състезанието и точките или актуализиране на точките, ако новите са повече
                    if (!students[username].ContainsKey(contest) || students[username][contest] < points)
                    {
                        students[username][contest] = points;
                    }
                }
            }

            // Намиране на най-добрия студент по общ брой точки
            string bestStudent = null;
            int maxTotalPoints = 0;

            foreach (var student in students)
            {
                int totalPoints = student.Value.Values.Sum();
                if (totalPoints > maxTotalPoints)
                {
                    maxTotalPoints = totalPoints;
                    bestStudent = student.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestStudent} with total {maxTotalPoints} points.");
            Console.WriteLine("Ranking:");

            // Отпечатване на резултатите
            foreach (var student in students.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
