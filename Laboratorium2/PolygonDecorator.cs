using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public abstract class PolygonDecorator : Shape
    {
        protected Shape triangle;
        public Vector2D[] Vertices;
    }
}
