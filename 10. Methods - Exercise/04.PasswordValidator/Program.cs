
using static System.Net.Mime.MediaTypeNames;

namespace _04.PasswordValidator
{
    internal class Program
    {
        /*  It should contain 6 – 10 characters (inclusive)
            It should contain only letters and digits
	        It should contain at least 2 digits 
        */
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();
            Console.WriteLine(PasswordValidator(textInput));
        }

        static string PasswordValidator(string textInput)
        {
            int totalNumbers = 0;
            string textResult = "";
            // CHECK LENGTH
            bool isCorrectLength = false;
            if (textInput.Length >= 6 && textInput.Length <= 10)
            {
                isCorrectLength = true;
            }
            // CHECK IF THERE ARE ONLY LETTERS AND DIGITS
            bool itContainsOnlyLettersAndDigits = textInput.All(char.IsLetterOrDigit); // true
            // CHECK MINIMUN 2 DIGITS
            bool gotTwoDigits = true;
            foreach (char symbol in textInput)
            {
                switch (symbol)
                {
                    case '0': totalNumbers++; break;
                    case '1': totalNumbers++; break;
                    case '2': totalNumbers++; break;
                    case '3': totalNumbers++; break;
                    case '4': totalNumbers++; break;
                    case '5': totalNumbers++; break;
                    case '6': totalNumbers++; break;
                    case '7': totalNumbers++; break;
                    case '8': totalNumbers++; break;
                    case '9': totalNumbers++; break;
                }
            }
            if (totalNumbers < 2)
            {
                gotTwoDigits = false;
            }
            
            if (!isCorrectLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!itContainsOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!gotTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isCorrectLength && gotTwoDigits && itContainsOnlyLettersAndDigits)
            {
                textResult = "Password is valid";
            }
            return textResult;
        }
    }
}
