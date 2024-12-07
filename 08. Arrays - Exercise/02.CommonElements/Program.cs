string[] arrayOne = Console.ReadLine().Split(" ").ToArray();
string[] arrayTwo = Console.ReadLine().Split(" ").ToArray();

for (int i = 0; i < arrayTwo.Length; i++)
{
    for (int j = 0; j < arrayOne.Length; j++)
    {
        if (arrayTwo[i] == arrayOne[j])
        {
            //Console.WriteLine($"There is common element at possition {j} at the first array and possition {i} at the seccond ");
            Console.Write($"{arrayOne[j]} ");
        }
    }
}