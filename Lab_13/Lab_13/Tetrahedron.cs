using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Tetrahedron : Figure
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
        #region ctors
        public Tetrahedron(double aside)
        {
                A = aside;
        }
        public Tetrahedron() { A = 1; }
        #endregion

        #region Overriden Methods
        public override double GetArea()
        {
            return (Math.Pow(A, 2) * Math.Sqrt(3));
        }
        public override string ToString()
        {
            return $"The area of Tetrahedron is - {GetArea():f2}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Tetrahedron tetra = obj as Tetrahedron;
            if (tetra != null)
            {
                if (tetra.A == A)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        #endregion
    }
}
