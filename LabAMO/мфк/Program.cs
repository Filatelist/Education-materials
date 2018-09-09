using System;
namespace Laboratory2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f(x)=e^(t^2) ");
            double a = 0, b = 0, fidility = 0.0001;
            int n = 1;
            for (b = 0; b < 1; b += 0.1)
            {
                Console.WriteLine("f({0})={1}", b, FidilityIntegralbyRunge(a, b, n, fidility));
            }
        }

        static double CalcIntegral(double a, double b, int n)
        {
            int i;
            double result = 0, h = (b - a) / n;

            for (i = 0; i < n; i++)
            {

                result += Math.Exp(Math.Pow((a + h * (i + 0.5)), 2));

            }
            result *= h;
            return result;
        }
        static double FidilityIntegralbyRunge(double a, double b, int n, double fidility)
        {
            int coef = 3;
            do
            {
                n *= 10;
            }
            while (fidility <= (CalcIntegral(a, b, 2 * n) - CalcIntegral(a, b, n)) / coef);

            return CalcIntegral(a, b, n);
        }
    }
}
