using System;

namespace metodHord
{
    class Program
    {
        static void Main(string[] args)
        {
            double x0 = 0;
            double x1 = 2;
            double e = 0.0001;
            double x = method_chord(x0, x1, e);
            Console.WriteLine(x);
            Console.WriteLine();
            Console.WriteLine(Newton(x1, e));

        }

        public static double method_chord(double a, double b, double e)//метод Хорд
        {
            while (Math.Abs(b - a) > e)
            {
                a = b - (b - a) * f(b) / (f(b) - f(a));
                b = a - (a - b) * f(a) / (f(a) - f(b));
            }
            return b;
        }

        public static double f(double x) //значення функції
        {
            return (x + Math.Pow(x, 0.5) + Math.Pow(x, 0.333) + Math.Pow(x, 0.25) - 5);//значення функції
        }
        public static double f_derevative(double x)//Значення похідної
        {
            return 1 + Math.Pow(x, -0.5) / 2 + Math.Pow(x, -2 / 3) / 3 + Math.Pow(x, -3 / 4) / 4;
        }
        public static double Newton(double x, double e) //Рекурсивний метод Ньютона
        {
            double y = x;
            x = x - f(x) / f_derevative(x);
            if (Math.Abs(y - x) >= e) return Newton(x, e);
            else { return x; };

        }
    }
}
