using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class sqrt
    {
        static void Main()
        {
            Point p1 = new Point();
           
            Point p2 = new Point();

            p1.X = 10;
            p1.Y = 50;
            p2.X = 2;
            p2.Y = 15;


            var distance = Distance(p1, p2);
            double x1 = p1.X;
            double y1 = p1.Y;
            double x2 = p2.X;
            double y2 = p2.Y;

            Console.WriteLine("p1.X, p1.Y = " + x1 + ", " + y1);
            Console.WriteLine("p2.X, p2.Y = " + x2 + ", " + y2);
            Console.WriteLine("The distance between {0}, {1} and {2}, {3} is {4}", x1, y1, x2, y2, distance);

        }
        public static double Distance(Point p1, Point p2)
        {
            double step1 = Math.Pow((p2.X - p1.X), 2.0);
            double step2 = Math.Pow((p2.Y - p1.Y), 2.0);
            double result = Math.Sqrt(step1 + step2);

            return result;

            
        }


    }
}
