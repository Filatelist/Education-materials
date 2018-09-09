using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class FallenChars
    {
        private int stringlength;
        private int posX;
        private int posY;
        static Random rnd = new Random();
        public void DrawString()
        {
            for (int i = 0; i < this.stringlength; i++)
            {
                for (int j = 0; j < j+i; j++)
                {
                    SetCharColor(i,j);
                    Console.SetCursorPosition(this.posX,this.posY+j);
                    Console.WriteLine($"{Convert.ToChar(rnd.Next(16,200))}");
                    
                    Thread.Sleep(210);
                    
                }
            }
        }
        public void SetCharColor(int v1,int v2)
        {

            if (v2 == v1)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (v2 == v1 - 1)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if(rnd.Next(2,66) %2==0)
            { Console.ForegroundColor = ConsoleColor.DarkGreen; }
            else Console.ForegroundColor = ConsoleColor.Green;
        }
        public FallenChars()
        {
            this.stringlength = rnd.Next(2,200);
            this.posX = rnd.Next(0, Console.WindowWidth);
            this.posY = rnd.Next(0, Console.WindowHeight/4);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Like in Matrix");
            int w = 40, h = 58;
            Console.SetWindowSize(h,w);
            int i = 0;
            for (; i < 20; i++)
            {
                new Thread(delegate () { new FallenChars().DrawString(); }).Start();
                
            }
            Console.ReadKey();
        }
             

        }
    
}
