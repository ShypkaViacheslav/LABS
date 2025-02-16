using System;

namespace PointLibrary
{
    public class Point3D
    {
        protected double x, y, z;

        public Point3D(double x = 0, double y = 0, double z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X => x;
        public double Y => y;
        public double Z => z;

        public double DistanceToOrigin() => Math.Sqrt(x * x + y * y + z * z);

        public double DistanceTo(Point3D other) =>
            Math.Sqrt(Math.Pow(other.x - x, 2) + Math.Pow(other.y - y, 2) + Math.Pow(other.z - z, 2));
    }

    public class ColoredPoint3D : Point3D
    {
        public string Color { get; }

        public ColoredPoint3D(double x, double y, double z, string color) : base(x, y, z)
        {
            Color = color;
        }
    }
}