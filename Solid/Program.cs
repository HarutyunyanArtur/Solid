using System;
using System.Collections.Generic;

namespace Solid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape shape = new Shape(2, 5);
            var shape_area = shape.getArea();
            Console.WriteLine(shape_area);

            //Console.ReadLine();

        }
    }
    public class Shape
    {
        public const int square = 1;
        public const int circle = 2;
        private readonly double width;
        public int type = -1;

        public Shape(int type, double width)
        {
            this.type = type;
            this.width = width;
        }

        public double getArea()
        {
            switch (type)
            {
                case square:
                    return width * width;
                case circle:
                    return Math.PI * width * width;
            }
            throw new SystemException("Can`t compute area of unknown shape");
        }
    }
}
