int totalNumbers = int.Parse(Console.ReadLine());

decimal sum = 0;
for (int number = 0; number < totalNumbers; number++)
{ 
    sum += decimal.Parse(Console.ReadLine());
}
Console.WriteLine(sum);