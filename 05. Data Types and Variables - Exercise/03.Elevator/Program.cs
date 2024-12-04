namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int maxCapacity = int.Parse(Console.ReadLine());

            int courses = people / maxCapacity;
            int remainder = people % maxCapacity;
            if (remainder == 0)
            {
                Console.WriteLine(courses);
                return;
            }
            if (remainder <= maxCapacity)
            {
                courses++;
            }

            Console.WriteLine(courses);


            //Console.WriteLine($"There are {courses} full courses with capacity of {maxCapacity} people");
            //Console.WriteLine($"There are {remainder} people left");
        }
    }
}
