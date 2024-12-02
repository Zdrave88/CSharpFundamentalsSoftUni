/*
 •	A count of people who are going on vacation.
•	Type of the group (Students, Business or Regular).
•	The day of the week which the group will stay on (Friday, Saturday or Sunday).
 */

int peopleAmount = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();

double price = 0.0;
switch (groupType)
{
    case "Students":
        if (day == "Friday")
        {
            price = 8.45;
        }
        else if (day == "Saturday")
        {
            price = 9.80;
        }
        else
        {
            price = 10.46;
        }
        break;
    case "Business":
        if (day == "Friday")
        {
            price = 10.90;
        }
        else if (day == "Saturday")
        {
            price = 15.60;
        }
        else
        {
            price = 16;
        }
        break;
    case "Regular":
        if (day == "Friday")
        {
            price = 15;
        }
        else if (day == "Saturday")
        {
            price = 20;
        }
        else
        {
            price = 22.50;
        }
        break;
}
double totalPrice = peopleAmount * price;

if (groupType == "Students" && peopleAmount >= 30)
{
    totalPrice *= 0.85;
}
if (groupType == "Business" && peopleAmount >= 100)
{
    totalPrice -= 10 * price;
}
if (groupType == "Regular" && peopleAmount >= 10 && peopleAmount <= 20)
{
    totalPrice *= 0.95;
}
Console.WriteLine($"Total price: {totalPrice:f2}");