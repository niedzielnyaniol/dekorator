using System.Collections.Generic;

namespace Laboratorium2
{
    public class SquareAdapter
    {
        private Polygon _square;

        public List<Vector2D> Verticles
        {
            get
            {
                return _square.Vertices;
            }
        }

        public double Area
        {
            get
            {
                return (Verticles[3].X - Verticles[0].X) * (Verticles[3].Y - Verticles[0].Y);
            }
        }

        public SquareAdapter(Vector2D p1, double width, double height)
        {
            var p2 = new Vector2D(p1.X + width, p1.Y);
            var p3 = new Vector2D(p1.X, p1.Y + height);
            var p4 = new Vector2D(p1.X + width, p1.Y + height);

            _square = new Polygon(new Triangle(p1, p2, p3), p4);
        }

    }
}
