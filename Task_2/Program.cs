using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the figure: ");
            string figureName = Console.ReadLine();
            Figure figure = new Figure(figureName);
            Console.WriteLine($"Perimeter of {figure.Name}: {figure.CalculatePerimeter()}");
            Console.ReadKey();
        }
    }
}