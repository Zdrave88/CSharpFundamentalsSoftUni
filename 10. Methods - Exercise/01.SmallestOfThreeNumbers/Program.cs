

namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int numC = int.Parse(Console.ReadLine());

           // Console.WriteLine(PrintHighestNumber(numA, numB, numC));
            Console.WriteLine(PrintLowestNumber(numA, numB, numC));
        }

        static int PrintLowestNumber(int numA, int numB, int numC)
        {
            int lowestNum = 0;
            if (numA < numB && numA < numC)
            {
                lowestNum = numA;
            }
            else if (numB < numA && numB < numC)
            {
                lowestNum = numB;
            }
            else
            {
                lowestNum = numC;
            }
            return lowestNum;
        }

        static int PrintHighestNumber(int numA, int numB, int numC)
        {
            int highestNum = 0;
            if (numA > numB && numA > numC)
            {
                highestNum = numA;
            }
            else if (numB > numA && numB > numC)
            {
                highestNum = numB;
            }
            else
            {
                highestNum = numC;
            }
            return highestNum;
        }
    }
}
