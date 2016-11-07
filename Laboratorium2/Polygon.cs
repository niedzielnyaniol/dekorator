using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Polygon : PolygonDecorator
    {
        public Polygon(Triangle triangle,params Vector2D[] vertices)
        {
            this.triangle = triangle;
            Vertices = new List<Laboratorium2.Vector2D> { triangle.a, triangle.b, triangle.c };
            foreach (var vert in vertices)
            {
                Vertices.Add(vert);
            }
        }

        public override void draw()
        {
            Console.Write("Rysuję wielokąt o " + (Vertices.Count) + " bokach: ");
            foreach (var item in Vertices)
            {
                Console.Write(" [" + item.X + ", " + item.Y + "]");
            }
            Console.WriteLine();
        }

        private double area()
        {
            double tmp_area = 0;

            for (int i = 0; i < Vertices.Count; i++)
            {
                if (i == 0)
                {
                    tmp_area += Vertices[i].X * (Vertices[Vertices.Count - 1].Y - Vertices[i + 1].Y);
                }
                else if (i == (Vertices.Count - 1))
                {
                    tmp_area += Vertices[i].X * (Vertices[i - 1].Y - Vertices[0].Y);
                }
                else
                {
                    tmp_area += Vertices[i].X * (Vertices[i - 1].Y - Vertices[i + 1].Y);
                }
            }

            if (tmp_area < 0)
            {
                tmp_area = -tmp_area;
            }

            tmp_area /= 2;

            return tmp_area;
        }

        public override double Area
        {
            get
            {
                return area();
            }
        }

        public override void translate(Vector2D t_vector)
        {
            throw new NotImplementedException();
        }
    }
}
