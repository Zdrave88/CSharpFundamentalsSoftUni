namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int intInput1 = int.Parse(Console.ReadLine());
                    int intInput2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(PrintMax(intInput1, intInput2));
                    break;
                case "char":
                    char charInput1 = char.Parse(Console.ReadLine());
                    char charInput2 = char.Parse(Console.ReadLine());
                    Console.WriteLine(PrintMax(charInput1, charInput2));
                    break;
                case "string":
                    string stringInput1 = Console.ReadLine();
                    string stringInput2 = Console.ReadLine();
                    Console.WriteLine(PrintMax(stringInput1, stringInput2));
                    break;

            }
        }
        static int PrintMax(int intInput1, int intInput2)
        {
            if (intInput1 > intInput2)
            {
                return intInput1;
            }
            return intInput2;
        }
        static char PrintMax(char charInput1, char charInput2)
        {
            if (charInput1 > charInput2)
            {
                return charInput1;
            }

            return charInput2;

        }
        static string PrintMax(string stringInput1, string stringInput2)
        {
            int result = stringInput1.CompareTo(stringInput2);
            if (result > 0)
            { 
                return stringInput1;
            }
            return stringInput2;
        }
    }
}
