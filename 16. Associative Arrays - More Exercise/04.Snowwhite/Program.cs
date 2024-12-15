using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhiteDwarfs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основен речник, който съхранява джуджетата с ключ комбинация от име и цвят
            Dictionary<(string Name, string HatColor), int> dwarfsData = new Dictionary<(string, string), int>();

            // Речник, който брои джуджетата по цветове на шапките
            Dictionary<string, int> hatColorCount = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                // Разделяме входа на име, цвят на шапка и физика
                string[] dwarfInfo = input.Split(" <:> ");
                string dwarfName = dwarfInfo[0];
                string hatColor = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                var dwarfKey = (Name: dwarfName, HatColor: hatColor);

                // Ако джуджето вече съществува и новата физика е по-висока, обновяваме
                if (dwarfsData.ContainsKey(dwarfKey))
                {
                    if (dwarfsData[dwarfKey] < physics)
                    {
                        dwarfsData[dwarfKey] = physics;
                    }
                }
                else
                {
                    dwarfsData[dwarfKey] = physics;

                    // Актуализираме броя на джуджетата с този цвят на шапката
                    if (!hatColorCount.ContainsKey(hatColor))
                    {
                        hatColorCount[hatColor] = 0;
                    }
                    hatColorCount[hatColor]++;
                }
            }

            // Сортираме джуджетата по физика в низходящ ред и по брой на джуджетата с даден ц
