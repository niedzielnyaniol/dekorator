using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Vector3D : Vector2D
    {
        protected double z;
        public Vector3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public override string ToString()
        {
            return base.ToString().Remove(base.ToString().Length - 1) + " ," + z.ToString() + "]";
        }

        private static Vector3D toVector(object obj)
        {
            if (obj is Vector3D)
            {
                Vector3D tmp = obj as Vector3D;
                return tmp;
            }
            throw new ArgumentException("Obiekt nie jest wektorem 3D.");
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Vector3D tmp = Vector3D.toVector(obj);

            return (z == tmp.z && y == tmp.y && x == tmp.x);
        }

        public void draw()
        {
            Console.WriteLine("Rysuję wektor: " + ToString());
        }

        public int CompareTo(object obj)
        {
            Vector3D t_obj = Vector3D.toVector(obj);
            int cmp = this.x.CompareTo(t_obj.x);
            if (cmp == 0) return this.y.CompareTo(t_obj.y);
            return cmp;
        }

        /**
            Przeciążanie operatorów
        **/

        public static Vector3D operator +(Vector3D l, Vector3D r)
        {
            return new Vector3D(l.x + r.x, l.y + r.y, l.z + r.z);
        }

        public static Vector3D operator -(Vector3D l, Vector3D r)
        {
            return new Vector3D(l.x - r.x, l.y - r.y, l.z - r.z);
        }

        public static Vector3D operator *(Vector3D l, double a)
        {
            return new Vector3D(l.x * a, l.y * a, l.x * a);
        }

        public static Vector3D operator *(double a, Vector3D l)
        {
            return new Vector3D(l.x * a, l.y * a, l.z * a);
        }

        public static Vector3D operator /(Vector3D l, double a)
        {
            return new Vector3D(l.x / a, l.y / a, l.z / a);
        }

        public static Vector3D operator /(double a, Vector3D l)
        {
            return new Vector3D(l.x / a, l.y / a, l.z / a);
        }
    }
}
