namespace демо
{
    internal class Program
    {
        public static bool IsPalindrome { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome);
        }
    }
}


namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+': Console.WriteLine(AddingNumbers(num1, num2)); break;
                case '-': Console.WriteLine(SubstractingNumbers(num1, num2)); break;
                case '*': Console.WriteLine(MutiplyingNumbers(num1, num2)); break;
                case '/': Console.WriteLine(DividingNumbers(num1, num2)); break;
            }
        }
        static int AddingNumbers(int num1, int num2)
        { 
            int result = num1 + num2; 
            return result;
        }
        static int SubstractingNumbers(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        static int MutiplyingNumbers(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static int DividingNumbers(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
