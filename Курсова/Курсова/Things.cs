using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова
{
    class Things
    {
        private int price;
        private string producer;
        private string name;
        //__________________________________________________________
        public virtual string SetName
        { get { return this.name; } set { this.name = value; } }
        //__________________________________________________________
        public virtual int SetPrice
        { get { return this.price; } set { this.price = value; } }
        //__________________________________________________________
        public virtual string SetProducer
        { get { return this.producer; } set { this.producer = value; } }
    }
    class HouseHold : Things
    {
        //__________________________________________________________
        public override string SetName
        { get => base.SetName; set => base.SetName = value; }
        //__________________________________________________________
        public override int SetPrice
        { get => base.SetPrice; set => base.SetPrice = value; }
        //__________________________________________________________
        public override string SetProducer
        { get => base.SetProducer; set => base.SetProducer = value; }
    }

    class ForTourism : Things
    {
        private int waterprooflevel;
        //__________________________________________________________
        public override string SetName
        { get => base.SetName; set => base.SetName = value; }
        //__________________________________________________________
        public override int SetPrice
        { get => base.SetPrice; set => base.SetPrice = value; }
        //__________________________________________________________
        public override string SetProducer
        { get => base.SetProducer; set => base.SetProducer = value; }
    }
}
