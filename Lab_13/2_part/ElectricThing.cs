using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_part
{
    abstract class ElectricThing
    {
        private string name;
        private double power;
        private double efficient;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != "fool")
                {
                    name = value;
                }
                else throw new Exception("Invalid name");
            }
        }

        public double Power
        {
            get { return power; }
            set
            {
                if (value >= 0)
                {
                    power = value;
                }
                else throw new Exception("Invalid power");
            }
        }

        public double Efficient
        {
            get
            {
                return efficient;
            }
            set
            {
                if (efficient >= 0 && efficient <= 100)
                    efficient = value/100;
                else throw new Exception("Invalid efficient");
            }
        }
        #region ctors

        public ElectricThing():this("default", 0, 100) { }
        
        public ElectricThing(string cname,double cpower,double cefficient)
        {
            if (cname != "fool")
                name = cname;
            else throw new Exception("Invlalid name");
            if (cpower >= 0)
                power = cpower;
                else throw new Exception(" ERROR: Power can`t be lower than 0");

            if (cefficient <= 100 || cefficient >= 0)
                efficient = cefficient/100;
                else throw new Exception(" ERROR: Efficient can`t be lower than 0% and higher than 100%");
        }
        
        #endregion

        public abstract double EfficientGet(double power);
        public abstract bool InUse();
    }
    
    
}
