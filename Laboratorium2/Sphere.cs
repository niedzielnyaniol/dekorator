using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Sphere : Circle
    {
        private Vector3D center;
        private double radius;

        public Vector3D Center
        {
            get { return center; }
            set { center = value; }
        }

        public Sphere(double r)
        {
            center = new Vector3D(0, 0, 0);
            radius = r;
        }

        public Sphere(Vector3D c, double r = 0)
        {
            center = c;
            radius = r;
        }

        public Sphere()
        {
            center = new Vector3D(0, 0, 0);
            radius = 0;
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję kulę o środku w: " + this.center.ToString() + " i promieniu: " + this.radius.ToString());
        }

        public override void translate(Vector2D t_vector)
        {
            if (t_vector is Vector3D)
            {
                Vector3D tmp = t_vector as Vector3D;
                this.center = this.center + tmp;
            }

            throw new Exception("Vector 2D except 3d");
        }

        public override double Area
        {
            get
            {
                return 4 * Math.PI * radius * radius;
            }
        }
        public override string getDescription()
        {
            return "Kula: " + this.center.ToString() + " i promieniu: " + this.radius.ToString();
        }
    }
}
