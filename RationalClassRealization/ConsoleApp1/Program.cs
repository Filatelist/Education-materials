using System;
namespace Laboratory4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            double fidility = 0.0001;
            Console.WriteLine(new string('_', 50));

            double x1=0 , x2=0, x3=0,x11=0,x12=0,x13=0;
            

                do
                {
                    x1 = x11; x2 = x12; x3 = x13;

                    x11 = 0.75 - 0.63 * x2 - (-0.25) * x3;
                    x12 = 0.0833 - 0.17 * x1 -(- 0.0833) * x3;
                    x13 = 1.2 - 0.2 * x1 - 0.2 * x2;    
                    Console.WriteLine("x=1.00 x2={0:f3} x3={1:f3}", x12, x13);

                
            } while (Math.Abs((x1-x11))>((1-0.875)/0.875)*fidility&& Math.Abs((x2 - x12)) > ((1 - 0.875) / 0.875) * fidility&& Math.Abs((x3 - x13)) > ((1 - 0.875) / 0.875) * fidility);
                
            Console.WriteLine(new string('_', 50));
        } 
        //8x+5x2-2x3 =6
        //x1 + x2 + 5x3 = 6
        //2x1+12x2-x3 = 1

    }
}
