using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Figure
    {
        public abstract double GetArea();
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
