using System;

namespace Laboratorium2
{
    public class Vector3D_Decorator : IComparable, IDrawable, IVector
    {
        protected Vector2D _vector = null;
        protected double z;

        public Vector3D_Decorator(double x, double y, double z)
        {
            this._vector = new Vector2D(x, y);
            this.z = z;
        }

        public double Y
        {
            get { return this._vector.Y; }
            set { this._vector.Y = value; }
        }

        public double X
        {
            get { return this._vector.X; }
            set { this._vector.X = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public override string ToString()
        {
            return "[" + this._vector.X.ToString() + " , " + this._vector.Y.ToString() + " , " + this.z.ToString() + "]";
        }

        private static Vector3D_Decorator toVector(Object obj)
        {
            if (obj is Vector3D_Decorator)
            {
                Vector3D_Decorator t_obj = obj as Vector3D_Decorator;
                return t_obj;
            }
            throw new ArgumentException("Obiekt nie jest wektorem.");

        }

        public int CompareTo(object obj)
        {
            Vector3D_Decorator t_obj = Vector3D_Decorator.toVector(obj);
            int cmp = this.X.CompareTo(t_obj.X);
            if (cmp == 0) return this.Y.CompareTo(t_obj.Y);
            return cmp;
        }

        public override bool Equals(object obj)
        {
            Vector3D_Decorator t_obj = Vector3D_Decorator.toVector(obj);
            if (this._vector.Equals(t_obj._vector) && this.z == t_obj.z) return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void draw()
        {
            Console.WriteLine("Rysuję wektor: " + this.ToString());
        }

        public static Vector3D_Decorator operator +(Vector3D_Decorator l, Vector3D_Decorator r)
        {
            return new Vector3D_Decorator(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        public static Vector3D_Decorator operator -(Vector3D_Decorator l, Vector3D_Decorator r)
        {
            return new Vector3D_Decorator(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        public static Vector3D_Decorator operator *(Vector3D_Decorator l, double a)
        {
            return new Vector3D_Decorator(l.X * a, l.Y * a, l.Z * a);
        }

    }
}
