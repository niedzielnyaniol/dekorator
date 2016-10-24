using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    class Program
    {
        static double multiplier = 10.0;
        static void Main(string[] args)
        {
            Shape s = new Triangle(new Vector2D(1, 2), new Vector2D(3, 2), new Vector2D(1, 23));
            Polygon p = new Polygon(s, new Vector2D(2.3, 1), new Vector2D(2.3, 1), new Vector2D(2.3, 1));

            p.draw();
            
        }
    }
}
