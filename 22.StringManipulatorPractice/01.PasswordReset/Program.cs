namespace demostration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                {
                    string action = arguments[0];
                    switch (action)
                    {
                        case "TakeOdd":
                            password = GenerateNewPassword(password);
                            break;
                        case "Cut":
                            password = ReducePasswordLength(int.Parse(arguments[1]), int.Parse(arguments[2]), password);
                            break;
                        case "Substitute":
                            password = ReplacePasswordElements(arguments[1], arguments[2], password);
                            break;
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }

        static string GenerateNewPassword(string password)
        {
            //string newPassword = "";
            //for (int i = 1; i < password.Length; i += 2)
            //{
            //    newPassword += password[i];
            //}

            string newPassword = new string(password.Where((c, i) => i % 2 != 0).ToArray());
            password = newPassword;
            Console.WriteLine(password);
            return password;
        }

        static string ReducePasswordLength(int index, int length, string password)
        {
            password = password.Remove(index, length);
            Console.WriteLine(password);
            return password;
        }

        static string ReplacePasswordElements(string substring, string replacement, string password)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, replacement);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }
    }
}
}

