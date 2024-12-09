namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"add", "multiply", "subtract", "divide"

            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (command == "add")
            { 
                AddingNumbers(num1, num2);
            }
            if (command == "multiply")
            {
                MultiplyingNumbers(num1, num2);
            }
            if (command == "subtract")
            {
                SubstractingNumber(num1, num2);
            }
            if (command == "divide")
            {
                DividingNumber(num1, num2);
            }
        }

        static void AddingNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 += num2);
        }
        static void MultiplyingNumbers(int num1, int num2)
        {
            Console.WriteLine(num1 *= num2);
        }
        static void SubstractingNumber(int num1, int num2)
        {
            Console.WriteLine(num1 -= num2);
        }
        static void DividingNumber(int num1, int num2)
        {
            Console.WriteLine(num1 /= num2);
        }
    }
}
