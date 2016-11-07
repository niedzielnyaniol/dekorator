using System;

namespace Laboratorium2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle s = new Triangle(new Vector2D(1, 0), new Vector2D(2, 1), new Vector2D(3, 1));
            Polygon p = new Polygon(s, new Vector2D(4, 0));

            p.draw();
            Console.WriteLine("Pole powierzchni: " + p.Area);

            SquareAdapter sa = new SquareAdapter(new Vector2D(5, 10), 5, 5);
            Console.WriteLine(sa.Area);
        }
    }
}
