//int totalLines = int.Parse(Console.ReadLine());

//for (int line = 1; line < totalLines; line++)
//{
//    var input = Console.ReadLine();
//    if (input.Length == 1)
//    {
//        char symbol = char.Parse(input);
//    }
//    else
//    {
//        string text = input;
//    }
//    Console.WriteLine(input);

//}


int totalLines = int.Parse(Console.ReadLine());
int openCount = 0;
bool lastWasOpen = false;
bool isBalanced = true;

for (int i = 0; i < totalLines; i++)
{
    string input = Console.ReadLine();

    if (input == "(")
    {
        if (lastWasOpen) 
        {
            isBalanced = false;
            break;
        }
        openCount++;
        lastWasOpen = true; 
    }
    else if (input == ")")
    {
        if (openCount > 0)
        {
            openCount--; 
            lastWasOpen = false;
        }
        else
        {
            isBalanced = false;
            break;
        }
    }
    else
    {
        lastWasOpen = false; 
    }
}
if (isBalanced && openCount == 0)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}
