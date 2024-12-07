string[] words = Console.ReadLine().Split(" ").ToArray();
string[] words2 = Console.ReadLine().Split(" ").ToArray();
bool areEqual = false;

if (words.Length == words2.Length)
{
    areEqual = true;
}
for (int i = 0; i < words.Length; i++)
{
    if (words[i] == words2[i])
    {
        areEqual = true;
    }
}
if (areEqual == true)
{
    Console.WriteLine("Arrays are equal");
}
else
{
    Console.WriteLine("Arrays are not equal");
}
