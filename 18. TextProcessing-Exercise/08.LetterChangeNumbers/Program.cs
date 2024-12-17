namespace _08.LetterChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                bool isValid = false;
                if (username.Length >= 3 && username.Length <= 16)
                {
                    for (int i = 0; i < username.Length; i++)
                    {
                        if (username[i] == '_')
                        {
                            break;
                        }
                        else if (username[i] == '-')
                        {
                            break;
                        }
                        else if (!char.IsLetterOrDigit(username[i]))
                        {
                            break;
                        }
                        else
                        {
                            isValid = true;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }

                }
            }
        }
    }
}
