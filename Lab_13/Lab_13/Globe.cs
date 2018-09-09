using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Globe : Figure
    {
        public double Radius
        { get { return Radius; }
            set
            {
                if (value >= 0)
                {
                    Radius = value;
                }
                else throw new Exception("Radius can`t be smaller than 0");
            }
        }
        #region ctors

        public Globe() { Radius = 1; }
        public Globe(double r)
        {
                Radius = r;
        }
        #endregion

        #region Overriden Methods

        public override double GetArea()
        {
            return (4 * Math.PI * Math.Pow(Radius, 2));
        }
        public override string ToString()
        {
            return $"Globe area is - {GetArea():f2}";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Globe globe = obj as Globe;
            if (globe != null)
            {
                if (globe.Radius == Radius)
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
