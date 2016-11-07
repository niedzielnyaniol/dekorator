using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public abstract class PolygonDecorator : Shape
    {
        protected Triangle triangle;
        public List<Vector2D> Vertices;
    }
}
