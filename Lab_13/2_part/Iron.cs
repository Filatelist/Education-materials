using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_part
{
    class Iron : ElectricThing
    {
        private decimal maxtemperature;
        public bool Haswater { get; set; }
        public decimal Maxtemparature
        {
            get { return maxtemperature; }
            set
            {
                if (value >= 0 && value <= 300)
                    maxtemperature = value;
                else throw new Exception("Invalid temperature");
            }
        }
        Random random = new Random();
        public Iron() : this("default", 0, 100, false, 100)
        {

        }
        public Iron(string name, double power, double efficient, bool haswater, decimal maxtemperature)
            : base(name, power, efficient)
        {
            this.Haswater = haswater;

            if (maxtemperature <= 300 || maxtemperature >= 0)
                this.maxtemperature = maxtemperature;
            else throw new Exception("ERROR: Invalid trmperature");
        }
        public override string ToString()
        {
            return $"name is = {Name} power is {Power} efficient is {EfficientGet(Power)}";
        }
        public override bool InUse()
        {
            if (random.Next(0, 2) == 1)
            {
                return true;
            }
            else return false;
        }
        public override double EfficientGet(double power)
        {
            return Power * Efficient;
        }

    }
}
// Реалізація визначається типом посилання на обьект