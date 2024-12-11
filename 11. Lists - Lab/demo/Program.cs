using System.ComponentModel;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> input = new List<string>(new string [5]);

            //for (int i = 0; i < input.Count; i++)
            //{
            //    string currentInput = Console.ReadLine();

            //    input.Add(currentInput); // продължава да добавя след последният индекс

            //    //input[i] = currentInput;
            //}

            //Console.WriteLine(string.Join(" ", input));

            List<string> input = new();

            input.Add("Orphant");                      // add var in the list
            input.Add("Mergo");
            input.Add("Artorias"); 
            input.Add("Malenia");
            input.Add("Bloodborne");
            input.Add("Godfrey");
            input.Add("Malenia");
            input.Add("Patches");
      
            Console.WriteLine($"The list got {input.Count} elements");
            Console.WriteLine($"They are: {string.Join(" ", input)}");
            Console.WriteLine();
            input.Remove("Malenia");                // remove 1st element with this content 
            input.Remove("Malenia");
            input.Remove("Midra");                  // there is no such element

            Console.WriteLine($"Now the list got {input.Count} elements");
            Console.WriteLine($"They are: {string.Join(" ", input)}");
            Console.WriteLine();

            input.RemoveAt(0);                      // remove at index
            Console.WriteLine($"The list got {input.Count} elements");
            Console.WriteLine($"They are: {string.Join(" ", input)}");
            Console.WriteLine();

            input.Insert(0, "Sekiro");              // add at index, var in the list
            Console.WriteLine($"The list got {input.Count} elements");
            Console.WriteLine($"They are: {string.Join(" ", input)}");
            Console.WriteLine();


            input.Contains("Gherman");              // return TRUE/FALSE
            Console.WriteLine(input.Contains("Gherman"));       // False
            Console.WriteLine(input.Contains("BMW"));           // True
            Console.WriteLine();


            input.Sort();                           // sort the list in ALPHABETICAL ORDER
            Console.WriteLine($"The sortet list is : {string.Join(" ", input)}");
            Console.WriteLine();

            input.Reverse();                        // sort the list in OPPOSITE ORDER
            Console.WriteLine($"The reversed list is : {string.Join(" ", input)}");
            Console.WriteLine();
        }
    }
}
