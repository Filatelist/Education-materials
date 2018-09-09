using System;

namespace _2_part
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ElectricThing[] thing = new ElectricThing[6];

            thing[0] = new Iron("Tefal", 25, 1, true, 300);
            thing[1] = new Iron("SovietIron", 90, 5, true, 200);
            thing[2] = new Iron("Philips", 90, 5,false, 250);
            thing[3] = new Boiler("OTTO", 100, 1, 4, 5, true);
            thing[4] = new Boiler("Name", 80, 10, 2, 5, true);
            thing[5] = new Boiler("InSan", 110, 11, 3, 2, false);

            Console.WriteLine(new string('_', 50));
            for (int i = 0; i < thing.Length; i++)
            {

                Console.WriteLine(thing[i]);
                
                Console.WriteLine(new string('_', 50));
            }
            
        }

    }
}
