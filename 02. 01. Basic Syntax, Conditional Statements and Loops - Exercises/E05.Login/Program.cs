//•	If the password is incorrect, print "Incorrect password. Try again.".
//•	If the password is correct, print "User {username} logged in." and stop the program.


string password = Console.ReadLine();
string reversed = "";
int tries = 4;

for (int i = password.Length - 1; i >= 0; i--)
{
    reversed += password[i];
}

while (true)
{
    string input = Console.ReadLine();
    tries--;
    if (input == reversed)
    {
        Console.WriteLine($"User {password} logged in.");
        break;
    }
    else
    {
        if (tries == 0)
        {
            Console.WriteLine($"User {password} blocked!");
            break;
        }
        Console.WriteLine("Incorrect password. Try again.");
    }
}