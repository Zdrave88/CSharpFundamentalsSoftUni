namespace RegularMidExam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double paymentPerSearch = double.Parse(Console.ReadLine());
            int totalUsers = int.Parse(Console.ReadLine());

            double totalIncome = 0;
            for (int user = 1; user <= totalUsers; user++)
            {
                int searchesPerUser = int.Parse(Console.ReadLine());

                double currentIncome = paymentPerSearch;

                if (searchesPerUser <= 1)
                {
                    continue;
                }
                if (user % 3 == 0)
                {
                    currentIncome *= 3;
                }
                if (searchesPerUser > 5)
                {
                    currentIncome *= 2;
                }
                totalIncome += currentIncome * searchesPerUser;
            }
            Console.WriteLine($"Total money earned: {totalIncome:f2}");
        }
    }
}
