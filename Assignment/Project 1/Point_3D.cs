using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Project_1
{
    internal class Point_3D : IComparable ,ICloneable
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point_3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Point_3D(int x) : this(x, 0, 0)
        {

        }

        public Point_3D(int x, int y) : this(x, y, 0)
        {

        }

        public Point_3D()
        {
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public int CompareTo(object? obj)
        {
            Point_3D? otherPoint = (Point_3D?)obj;
                int result = this.x.CompareTo(otherPoint?.x);
                if (result == 0)
                {
                    result = this.y.CompareTo(otherPoint?.y);
                }
            return result;
        }

        public object Clone()
        {
            return new Point_3D() { x=this.x,y=this.y,z=this.z};
        }
    }
}
