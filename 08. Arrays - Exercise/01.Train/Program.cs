int arrayLenght = int.Parse(Console.ReadLine());
int[] wagons = new int[arrayLenght];
int totalPeople = 0;

for (int i = 0; i < arrayLenght; i++)
{
    int people = int.Parse(Console.ReadLine());
    wagons[i] = people;
    totalPeople += people;
}
Console.WriteLine(string.Join(" ", wagons));
Console.WriteLine(totalPeople);