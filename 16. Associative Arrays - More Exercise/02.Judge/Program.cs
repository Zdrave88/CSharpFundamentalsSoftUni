using System;
using System.Collections.Generic;
using System.Linq;

namespace JudgeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Речник за състезанията и точките на потребителите
            Dictionary<string, Dictionary<string, int>> contestParticipants = new Dictionary<string, Dictionary<string, int>>();
            // Речник за общите точки на всеки потребител
            Dictionary<string, int> individualScores = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] parts = input.Split(" -> ");
                string username = parts[0];
                string contest = parts[1];
                int points = int.Parse(parts[2]);

                // Проверка и добавяне на състезание и потребител в contestParticipants
                if (!contestParticipants.ContainsKey(contest))
                {
                    contestParticipants[contest] = new Dictionary<string, int>();
                }

                // Ако потребителят вече е в това състезание, проверка за по-висока оценка
                if (contestParticipants[contest].ContainsKey(username))
                {
                    if (contestParticipants[contest][username] < points)
                    {
                        individualScores[username] += points - contestParticipants[contest][username];
                        contestParticipants[contest][username] = points;
                    }
                }
                else
                {
                    contestParticipants[contest][username] = points;

                    // Актуализация на общите точки на потребителя
                    if (!individualScores.ContainsKey(username))
                    {
                        individualScores[username] = 0;
                    }
                    individualScores[username] += points;
                }
            }

            // Отпечатване на информацията за всяко състезание
            foreach (var contest in contestParticipants)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int position = 1;
                foreach (var participant in contest.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{position}. {participant.Key} <::> {participant.Value}");
                    position++;
                }
            }

            // Отпечатване на индивидуалните класации
            Console.WriteLine("Individual standings:");
            int rank = 1;
            foreach (var user in individualScores
                .OrderByDescending(s => s.Value)
                .ThenBy(s => s.Key))
            {
                Console.WriteLine($"{rank}. {user.Key} -> {user.Value}");
                rank++;
            }
        }
    }
}
