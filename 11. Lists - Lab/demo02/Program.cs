
namespace demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToList();

            Console.WriteLine(string.Join(" ", PrintListResult(list)));

        
        }

        static List <double> PrintListResult(List<double> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);

                }
            }
            return list;
        }
    }
}
