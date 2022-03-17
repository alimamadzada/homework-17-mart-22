using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çevrenin sahesi= " + CalculateArea(3));
            Console.WriteLine("Düzbucaqlinin sahesi= " + CalculateArea(2, 4));
            Console.WriteLine("Düzbucaqli paralelpipedin tam sethinin sahesi= " + CalculateArea(2, 3, 4));
        }
        /// <summary>
        /// Prints the area of ​​the circle.
        /// </summary>
        /// <param name="r">int,represents the radius of the rectangle</param>
        /// <returns></returns>
        static int CalculateArea(int r)
        {
            return 3 * (r * r);
        }
        /// <summary>
        /// Prints the area of rectangle.
        /// </summary>
        /// <param name="a">int, represents length of the rectangle</param>
        /// <param name="b">int, represents width of the rectangle</param>
        /// <returns></returns>
        static int CalculateArea(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// Prints the total surface area of ​​a rectangular parallelepiped.
        /// </summary>
        /// <param name="a">int, represents the side of the seat</param>
        /// <param name="b">int, represents the side of the seat</param>
        /// <param name="c">int, represents the "length" of the parallelepiped</param>
        /// <returns></returns>
        static int CalculateArea(int a, int b, int c)
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
}
}
    }
}
