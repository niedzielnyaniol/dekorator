using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Polygon : PolygonDecorator
    {
        public Polygon(Shape triangle,params Vector2D[] vertices)
        {
            this.triangle = triangle;
            Vertices = vertices;
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję wielokąt o " + (3 + Vertices.Length) + " bokach");
        }

        public override void translate(Vector2D t_vector)
        {
            throw new NotImplementedException();
        }
    }
}
