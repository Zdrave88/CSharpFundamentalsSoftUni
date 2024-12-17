using System;

namespace BigNumberMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();  // Четем голямото число като низ
            int multiplier = int.Parse(Console.ReadLine());  // Четем едноцифреното число

            int carry = 0;  // Променлива за преноса
            string result = string.Empty;

            // Обхождаме всяка цифра от голямото число отдясно наляво
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                // Извличаме цифрата като цяло число
                int digit = bigNumber[i] - '0'; // '0' е кодът на цифрата '0', така че изваждаме '0', за да получим числото
                int product = digit * multiplier + carry;  // Умножаваме цифрата с множителя и добавяме преноса

                // Добавяме резултата към низа (резултатът е последователен)
                result = (product % 10) + result;  // Вземаме последната цифра от произведението
                carry = product / 10;  // Преносът за следващото умножение
            }

            // Ако има остатъчен пренос след последното умножение, го добавяме
            if (carry > 0)
            {
                result = carry + result;
            }

            // Извеждаме резултата
            Console.WriteLine(result);
        }
    }
}
