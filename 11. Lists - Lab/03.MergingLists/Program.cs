
namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToList();

            List<int> numbers2 = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToList();

            Console.WriteLine(PrintMergedList(numbers1, numbers2));
        }

        static string PrintMergedList(List<int> numbers1, List<int> numbers2)
        {
            int biggerListCount;
            if (numbers1.Count > numbers2.Count)
            {
                biggerListCount = numbers1.Count;
            }
            else
            { 
                biggerListCount= numbers2.Count;
            }
            List<int> mergedList = new();

            for (int i = 0; i < biggerListCount; i++)
            {
                if (numbers1.Count > i)
                {
                    mergedList.Add(numbers1[i]);
                }

                if (numbers2.Count > i)
                {
                    mergedList.Add(numbers2[i]);
                }
            }
            return string.Join(" ", mergedList);
        }
    }

 
}
