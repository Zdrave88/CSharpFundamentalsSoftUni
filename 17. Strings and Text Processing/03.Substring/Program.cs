//namespace _03.Substring
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            string textToRemove = Console.ReadLine();
//            string text = Console.ReadLine();

//            int index = text.IndexOf(textToRemove);

//            while (index != -1)
//            {
//                text = text.Substring(0, index) + text.Substring(index + textToRemove.Length);
//                index = text.IndexOf(textToRemove);
//            }
//        }
//    }
//}
//string textToRemove = Console.ReadLine();
//string text = Console.ReadLine();

//int index = text.IndexOf(textToRemove);

//while (index != -1)
//{
//    text = text.Remove(index, textToRemove.Length);
//    index = text.IndexOf(textToRemove);
//}
//Console.WriteLine(text);



/*
ice
kicegiciceeb
 */

string textToReplace = Console.ReadLine();
string text  = Console.ReadLine();
//string result = text.Replace(textToReplace, "");
//Console.WriteLine(result);                        // kgiceb

while (text.Contains(textToReplace))
{
    text = text.Replace(textToReplace, "");
}
Console.WriteLine(text);