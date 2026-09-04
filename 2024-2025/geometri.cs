using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose a geometric shape to calculate the area:");
                Console.WriteLine("1. Triangle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Circle");
                Console.WriteLine("4. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateTriangleArea();
                        break;
                    case "2":
                        CalculateRectangleArea();
                        break;
                    case "3":
                        CalculateCircleArea();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }

                Console.WriteLine("Do you want to calculate another area? (y/n)");
                if (Console.ReadLine().ToLower() != "y")
                {
                    break;
                }
            }
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter the base of the triangle:");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of the triangle:");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = TriangleArea(baseTriangle, height);
            Console.WriteLine($"The area of the triangle is: {area}");
        }

        static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = RectangleArea(length, width);
            Console.WriteLine($"The area of the rectangle is: {area}");
        }

        static void CalculateCircleArea()
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = CircleArea(radius);
            Console.WriteLine($"The area of the circle is: {area}");
        }

        static double TriangleArea(double baseTriangle, double height)
        {
            return 0.5 * baseTriangle * height;
        }

        static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
