using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_part
{

    class Heater : ElectricThing
    {
        private double volume;
        public double Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0)
                {
                    volume = value;
                }
                else volume = 1;
            }
        }
        decimal timeofwork;

        public decimal Timeofwork
        {
            get { return timeofwork; }
            set
            {
                if (value >= 0)
                    timeofwork = value;
                else throw new Exception("Invalid time");
            }
        }

        public Heater() : this("default heater name", 0, 100, 1, 1) { }
        public Heater(string name, double power, double efficient, double volume, decimal timeofwork)
            : base(name, power, efficient)
        {
            if (volume >= 0)
                this.Volume = volume;
            else throw new Exception("ERROR: Volume can`t be lower than 0");
            if (timeofwork >= 0)
                this.Timeofwork = timeofwork;
            else throw new Exception("ERROR: Time can`t be lower than 0");
        }

        public override string ToString()
        {
            return $"name is = {Name} power is {Power} efficient is {EfficientGet(Power)} volume is, time of work is {Timeofwork}";
        }
        public override double EfficientGet(double power)
        {
            return power * Efficient;
        }
        
        public override bool InUse()
        {
            return false;
        }
    }
}
