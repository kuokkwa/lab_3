using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Figure
    {
        private int number;
        private Point[] points;
        public string Name { get; set; }

        public void InitializeFigure()
        {
            Console.WriteLine("Enter the number of vertices of your figure:");
            number = int.Parse(Console.ReadLine());
            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"Enter coordinates for point {i + 1} (X Y Z):");
                string[] coordinates = Console.ReadLine().Split(' ');
                if (coordinates.Length != 3)
                {
                    Console.WriteLine("Something went wrong, please check the text you entered");
                    i--;
                    continue;
                }
                double x = Convert.ToDouble(coordinates[0]);
                double y = Convert.ToDouble(coordinates[1]);
                double z = Convert.ToDouble(coordinates[2]);
                points[i] = new Point(x, y, z);
            }
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i - 1], points[i]);
            }
            perimeter += LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }

        public Figure(string name)
        {
            Name = name;
            InitializeFigure();
        }
    }
}
