using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_part
{
    class Boiler : Heater
    {
        public bool Hastank { get; set; }
        Random random = new Random();
        public Boiler() : this("default", 0, 100, 0, 0, false)
        {

        }
        public Boiler(string name, double power, double efficient, double volume, decimal timeofwork, bool hastank)
            : base(name, power, efficient, volume, timeofwork)
        {
            this.Hastank = hastank;

            if (!Hastank)
            {
                Volume = 0;
            }
        }
        public new bool InUse()
        {
            if (random.Next(0, 2) == 1)
            {
                return true;
            }
            else return false;
        }

        public override string ToString()
        {
            return $"Name is {Name}, power is {Power}, efficient is {EfficientGet(Power)}, volume is {Volume}, time of work is {Timeofwork} min";
        }
    }
}
