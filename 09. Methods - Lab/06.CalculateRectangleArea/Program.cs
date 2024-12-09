namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = PrintTriangleArea(height, width);
            Console.WriteLine(area);
        }
        static double PrintTriangleArea(double height, double width)
        { 
            return (height * width);
        }
    }
}
