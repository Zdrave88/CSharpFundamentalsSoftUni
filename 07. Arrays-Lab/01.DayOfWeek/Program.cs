//                                        0         1           2           3          4          5          6
string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1: Console.WriteLine(daysOfWeek[0]); break;
    case 2: Console.WriteLine(daysOfWeek[1]); break;
    case 3: Console.WriteLine(daysOfWeek[2]); break;
    case 4: Console.WriteLine(daysOfWeek[3]); break;
    case 5: Console.WriteLine(daysOfWeek[4]); break;
    case 6: Console.WriteLine(daysOfWeek[5]); break;
    case 7: Console.WriteLine(daysOfWeek[6]); break;
    default: Console.WriteLine("Invalid day!"); break;
}

