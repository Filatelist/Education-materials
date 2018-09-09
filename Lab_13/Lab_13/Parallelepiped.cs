using System;
using System.Collections.Generic;
namespace Lab_13
{
    class Parallelepiped : Figure
    {
        public double A
        {
            get { return A; }
            set
            {
                if (value >= 0)
                    A = value;
                else throw new Exception("Side can`t be lower than 0");
            }
        }
        public double B
        {
            get { return B; }
            set
            {

                if (value >= 0)
                    B = value;
                else throw new Exception("Side can`t be lower than 0");
            }
        }
        public double C
        {
            get { return C; }
            set
            {

                if (value >= 0)
                    C = value;
                else throw new Exception("Side can`t be lower than 0");
            }
        }
        #region ctors
        public Parallelepiped(double aside, double bside, double cside)
        {
                A = aside;
                B = bside;
                C = cside;
        }
        public Parallelepiped() { A = 1; B = 1; C = 1; }
        #endregion
        #region Overriden Methods
        public override double GetArea()
        {
            return 2 * (A * B + A * C + B * C);
        }
        public override string ToString()
        {
            return $"Area of Parallelepiped is - {GetArea():f2}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Parallelepiped tetra = obj as Parallelepiped;
            if (tetra != null)
            {
                if (tetra.A == A)
                {

                    if (tetra.B == B)
                    {
                        if (tetra.C == C)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            } else return false;
        }
        #endregion
    }
}
