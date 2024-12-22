/*
    Open-Closed Principle (OCP) : 
        Software entities (classes, modules, functions, etc.) should be open 
        for extension but closed for modification.
*/

using Bad_Way;
using Good_Way;

namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Open Closed Principle");
        }
    }
}

namespace Bad_Way
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }

    public class AreaCalculator
    {
        public static double CalculateArea(object shape)
        {
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }
            // If new shapes are added, this method would need modification
            return 0;
        }
    }
}

// Solution to Above Problem
namespace Good_Way
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    /*
     * If in future here comes new shape
     * it will inherit Shape class and
     * override Area() method resulting
     * into extension of method without
     * disturbing existing functionality
      
        public class Triangle : Shape
        {
            public int Height { get; set; }

            public int Base { get; set; }

            public override double Area()
            {
                return 0.5 * Height * Base;
            }
        }

        Above mentioned code will be added
        without modifying existing code
     */

    public class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}