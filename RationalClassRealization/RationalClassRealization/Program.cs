using System;

namespace RationalClassRealization
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ; var num1 = new Rational(1, 2);
            ; var num2 = new Rational(2, 5);
            ; Rational result = num1 + num2;

            ; try
            {
                ; Console.WriteLine(result);
                ; Console.WriteLine($"Product - {num1 *num2}");
                ; Console.WriteLine($"Fraction - {num1/num2}");
                ; Console.WriteLine($"Difference - {num1 - num2}");
                ; Console.WriteLine($"Sum - {num1+num2}");
                
            }
            catch (DivideByZeroException e) { Console.WriteLine(e.Message); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            
        }
    }
}
