//double dul, sh, V = 0;
//Console.WriteLine("Length: ");
//dul = double.Parse(Console.ReadLine());
//Console.WriteLine("Width: ");
//sh = double.Parse(Console.ReadLine());
//Console.WriteLine("Heigth: ");
//V = double.Parse(Console.ReadLine());
//V = (dul + sh + V) / 3;
//Console.WriteLine($"Pyramid Volume: {V:f2}");


/*
 Hints
•	Reduce the span of the variables by declaring them at the moment they receive a value, not before.
•	Rename your variables to represent their real purpose (example: "dul" should become length, etc.).
•	Search for variables that have multiple purposes. If you find any, introduce a new variable.
*/


Console.Write($"Length: ");
double length = double.Parse(Console.ReadLine());

Console.Write($"Width: ");
double width = double.Parse(Console.ReadLine());

Console.Write($"Height: ");
double height = double.Parse(Console.ReadLine());

double volume = (length * width * height) / 3;
Console.Write($"Pyramid Volume: {volume:f2}");

