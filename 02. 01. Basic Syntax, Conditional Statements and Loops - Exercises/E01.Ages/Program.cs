/*
 •	0-2 – baby
•	3-13 – child
•	14-19 – teenager
•	20-65 – adult
•	>= 66 – elder

 */

int ageInput = int.Parse(Console.ReadLine());
string result = "";

if (ageInput >= 0 && ageInput <= 2)
{
    result = "baby";
}
else if (ageInput >= 3 && ageInput <= 13)
{
    result = "child";
}
else if (ageInput >= 14 && ageInput <= 19)
{
    result = "teenager";
}
else if (ageInput >= 20 && ageInput <= 65)
{
    result = "adult";
}
else if (ageInput >= 66)
{
    result = "elder";
}
else
{
    Console.WriteLine("error");
}
Console.WriteLine(result);