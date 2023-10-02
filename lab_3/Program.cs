namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lengths of two sides of the rectangle:");
            Console.Write("Side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine($"Perimeter: {rectangle.Perimeter}");
            Console.WriteLine($"Area: {rectangle.Area}");
        }
    }
}