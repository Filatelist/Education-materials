using System;
namespace Lab_13
{
    public delegate void Test();
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Globe sphere = new Globe(2);
                Parallelepiped parallelepiped = new Parallelepiped(2, 5, 4);
                Tetrahedron tetra = new Tetrahedron(12);
                Console.WriteLine(sphere);
                Console.WriteLine(parallelepiped);
                Console.WriteLine(tetra);
                Console.WriteLine(new string ('_',20));
                Console.WriteLine("Equalisations:");
                Console.WriteLine(sphere.Equals(sphere));
                Console.WriteLine(parallelepiped.Equals(parallelepiped));
                Console.WriteLine(tetra.Equals(tetra));
            }
            catch (FormatException) { Console.WriteLine("Incorrect format"); }
            catch (OverflowException) { Console.WriteLine("The number is too large"); }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
