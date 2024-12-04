int keyNumber = int.Parse(Console.ReadLine());
int totalRotations = int.Parse(Console.ReadLine());

for (int rotations = 1; rotations <= totalRotations; rotations++)
{
    char symbol = char.Parse(Console.ReadLine());
    int symbolNumber = (int)symbol;

    symbolNumber += keyNumber;
    char letter = (char)symbolNumber;

    Console.Write(letter);
}


