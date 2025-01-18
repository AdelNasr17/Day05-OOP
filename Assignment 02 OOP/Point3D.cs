using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02_OOP
{
    internal class Point3D
    {
        #region Properties

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #endregion

        #region onstructors 

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Point3D(int x, int y) : this(x, y, 0)
        {
        }

        public Point3D(int x) : this(x, 0, 0)
        {

        }


        #endregion

        public override string ToString()
        {
            return $" point Coordinates :({X}, {Y}, {Z})";
        }

        #region Methods 

        public static bool operator ==(Point3D P1, Point3D P2)
        {
            if (P1 is null || P2 is null)
                return false;
            else
                return P1.X == P2.X && P1.Y == P2.Y && P1.Z == P2.Z;
        }

        public static bool operator !=(Point3D P1, Point3D P2)
        {
            return !(P1 == P2);
        }

        #endregion

    }
}
