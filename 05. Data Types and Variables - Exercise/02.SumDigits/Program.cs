namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int inputCopy = numberInput;
            int sum = 0;

            while (inputCopy > 0)
            {
                sum += inputCopy % 10;
                inputCopy /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
