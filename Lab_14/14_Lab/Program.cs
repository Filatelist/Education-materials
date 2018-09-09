using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{
    struct Circle
    {

        public int X { get; set; }
        public int Y { get; set; }
        private int radius;
        public int Radius
        {
            get => radius;
            set
            {
                if (value >= 0)
                {
                    radius = value;

                }
                else throw new Exception("Invalid radius");
            }
        }
        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            this.radius = radius;
        }
        public Circle(Circle prevCircle)
        {
            X = prevCircle.X;
            Y = prevCircle.Y;
            radius = prevCircle.radius;
        }
        public bool IsContain(int x, int y)
        {
            return x == X && y == Y;
        }
        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public static int CompareRadius(Circle c1, Circle c2)
        {
            if (c1.Radius < c2.Radius) return -1;
            else if (c1.Radius > c2.Radius) return 1;
            if (c1.Radius == c2.Radius) return 0;
            else return 0;
        }
        public static int CompareArea(Circle c1, Circle c2)
        {
            if (c1.Area() < c2.Area()) return -1;
            else if (c1.Area() > c2.Area()) return 1;
            else if (c1.Area() == c2.Area()) return 0;
            else return 0;

        }
        public override string ToString()
        {
            return $"({X},{Y}) radius = {radius}, Area = {Area()}";
        }
    }
    class Container
    {
        public delegate int Compare(Circle c1, Circle c2);
        const int number = 4;
        List<Circle> circles = new List<Circle>();
        public void Add(Circle circle)
        {
            circles.Add(circle);
            if (circles.Count > number)
            {
                circles.Remove(circle);
                throw new Exception("Sorry, but the limit is reached");
            }
        }
        private Compare compare;

        public Compare CompareMethod { get => compare; set => compare = value; }

        public Container(Compare compare)
        {
            this.compare = compare;
        }
        public Container()
        {

        }
        public List<Circle> Quicksort(int left, int right)
        {
            int i = left, j = right;
            Circle pivot = circles[(left + right) / 2];
            while (i <= j)
            {
                while (compare(circles[i], pivot) < 0)
                {
                    i++;
                }

                while (compare(circles[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    Circle tmp = circles[i];
                    circles[i] = circles[j];
                    circles[j] = tmp;
                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(left, j);
            }

            if (i < right)
            {
                Quicksort(i, right);
            }

            return circles;
        }
        public void Remove(Circle item)
        {
            circles.Remove(item);
        }
    }
    class Program
    {
        static void GetCircle(List<Circle> circle, int number)
        {
            if (!circle[number].Equals(null))
            {
                Console.WriteLine("This is the element = " + circle[number]);
            }
            else Console.WriteLine("this element doesent exist");
        }
        static void GetCircleH(int x, int y, List<Circle> circle)
        {
            foreach (var item in circle)
            {
                if (item.X == x && item.Y == y)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static void AreaCircles(List<Circle> collection)
        {
            Console.WriteLine(collection[0] + " the least Area");
            Console.WriteLine(collection[collection.Count - 1] + " the biggest Area");
        }
        static Container.Compare GetMethod()
        {
            Container.Compare compMethod;
            Console.WriteLine("Chose the Method of Sorting:");
            Console.WriteLine("1. By Radius, input (r)");
            Console.WriteLine("2. By Area input any key");
            string s = (Console.ReadLine());
            if (s == "r")
            { compMethod = Circle.CompareArea; }
            else compMethod = Circle.CompareRadius;
            return compMethod;
        }
        
        static void Main(string[] args)
        {
            try
            {
                const int number = 4;
                List<Circle> circles = new List<Circle>();
                Container container = new Container();
                
                for (int i = 0; i < number; i++)
                {
                    Console.Write("X = ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Y = ");
                    int y = int.Parse(Console.ReadLine());
                    Console.Write("Radius = ");
                    int radius = int.Parse(Console.ReadLine());
                    container.Add(new Circle(x, y, radius));

                }

                container.CompareMethod = GetMethod();
                circles = container.Quicksort(0, number - 1);
                foreach (Circle item in circles)
                {
                    Console.WriteLine(item + ", ");
                }
                Console.WriteLine(new string('_', 50));
                AreaCircles(circles);
                Console.WriteLine("If ypu want to find the circle by number, input y, if you d like to find the circle by cordinates, input any other key:");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("Input the number of circle in collection = ");
                    GetCircle(circles, int.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Input the x which you would like to find");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inpu the y which you would like to find");
                    int y = int.Parse(Console.ReadLine());
                    GetCircleH(x, y, circles);
                }

            }
            catch (InvalidOperationException ex) when (ex.InnerException != null)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception) { Console.WriteLine("Error"); }
        }
    }
}
//12.	Ім’я структури: Circle
//•	поля: координати центру(x, y); радіус.
//•	конструктор: отримує значення координат центру кола та його радіус.
//•	метод Contains (перевіряє чи належить надана вершина колу), інші методи і властивості за необхідністю.
//Дії програми:
//•	виведення на екран елемента масиву (кола) із заданим номером (якщо такого кола немає, вивести відповідне повідомлення);
//•	виведення елементів масиву(кіл), яким належить задана координатами вершина(якщо таких немає, то вивести відповідне повідомлення);
//•	виведення елемента масиву з найменшою та з найбільшою площею.
