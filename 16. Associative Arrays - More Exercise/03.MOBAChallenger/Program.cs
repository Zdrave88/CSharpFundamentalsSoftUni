using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основен речник, който съхранява информацията за всеки играч
            Dictionary<string, Dictionary<string, int>> playersData = new Dictionary<string, Dictionary<string, int>>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    // Разделяме входа на играч, позиция и умение
                    string[] playerInfo = input.Split(" -> ");
                    string playerName = playerInfo[0];
                    string position = playerInfo[1];
                    int skill = int.Parse(playerInfo[2]);

                    // Проверяваме дали играчът вече съществува в списъка
                    if (!playersData.ContainsKey(playerName))
                    {
                        playersData[playerName] = new Dictionary<string, int>();
                    }

                    // Добавяме позицията и умението, или обновяваме, ако новото умение е по-високо
                    if (!playersData[playerName].ContainsKey(position) || playersData[playerName][position] < skill)
                    {
                        playersData[playerName][position] = skill;
                    }
                }
                else if (input.Contains("vs"))
                {
                    // Разделяме входа на двама играчи за дуел
                    string[] duelInfo = input.Split(" vs ");
                    string playerOne = duelInfo[0];
                    string playerTwo = duelInfo[1];

                    if (playersData.ContainsKey(playerOne) && playersData.ContainsKey(playerTwo))
                    {
                        // Проверка за обща позиция между двамата играчи
                        bool commonPositionFound = playersData[playerOne].Keys
                            .Any(position => playersData[playerTwo].ContainsKey(position));

                        if (commonPositionFound)
                        {
                            int playerOneTotalSkill = playersData[playerOne].Values.Sum();
                            int playerTwoTotalSkill = playersData[playerTwo].Values.Sum();

                            // Сравняваме тоталните умения и премахваме играча с по-ниски умения
                            if (playerOneTotalSkill > playerTwoTotalSkill)
                            {
                                playersData.Remove(playerTwo);
                            }
                            else if (playerOneTotalSkill < playerTwoTotalSkill)
                            {
                                playersData.Remove(playerOne);
                            }
                        }
                    }
                }
            }

            // Отпечатваме резултатите за всички играчи
            foreach (var player in playersData
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(p => p.Key))
            {
                string playerName = player.Key;
                int totalSkill = player.Value.Values.Sum();

                Console.WriteLine($"{playerName}: {totalSkill} skill");

                foreach (var positionData in player.Value
                    .OrderByDescending(p => p.Value)
                    .ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {positionData.Key} <::> {positionData.Value}");
                }
            }
        }
    }
}
