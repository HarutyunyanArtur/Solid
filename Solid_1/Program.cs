using System;
using System.Collections.Generic;

namespace Solid_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Width = 3;
            var circle_area = circle.GetArea();
            Console.WriteLine(circle_area);
            Sqaure quadrant = new Sqaure();
            quadrant.Width = 4;
            var quadrant_area = quadrant.GetArea();
            Console.WriteLine(quadrant_area);
        }
    }
    public interface IShape
    {
        int Width { get; set; }
        double GetArea();
    }

    public class Sqaure : IShape
    {
        public int Width { get; set; }

        public double GetArea()
        {
            double area = Width * Width;
            return area;
        }
    }

    public class Circle : IShape
    {
        public int Width { get; set; }

        public double GetArea()
        {
            double area = Math.PI * Width * Width;
            return area;
        }
    }
}
