using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long l;
            StreamWriter stream = new StreamWriter(@"E:\Buffer.jpeg");
            for (long i = 0; i < 900000000000; i++)
            {
                stream.Write(0);
                l = i;
                string s = l.ToString();
                Console.Write(s + "" );
                Console.Clear();

            }
            stream.Close();
        }
    }
}
