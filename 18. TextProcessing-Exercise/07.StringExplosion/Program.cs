using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;
        int explosionPower = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentElement = input[i];

            if (currentElement == '>')
            {
                result += currentElement;
                explosionPower += int.Parse(input[i + 1].ToString());
            }
            else if (explosionPower > 0)
            {
                explosionPower--;
            }
            else
            {
                result += currentElement;
            }
           
        }
        Console.WriteLine(result);
    }
}
