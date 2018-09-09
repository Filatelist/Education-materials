using System;
using System.Collections.Generic;

namespace RationalClassRealization
{
    class Rational
    {
        
        private int numerator;
        private int denominator;

        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }
        public Rational(int numer, int denomin)
        {
            this.numerator = numer;
            this.denominator = denomin;
        }
        #region Overloaded operators
        public static Rational operator +(Rational r1, Rational r2)
        {
            Rational result = new Rational();
            
            result.numerator = (r1.numerator * r2.denominator) + (r2.numerator * r1.denominator);
            result.denominator = (r1.denominator * r2.denominator);
            return result;
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational result = new Rational();
            result.numerator = (r1.numerator * r2.denominator) - (r2.numerator * r1.denominator);
            result.denominator = (r1.denominator * r2.denominator);
            return result;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            Rational result = new Rational();
            result.numerator = (r1.numerator * r2.numerator);
            result.denominator = (r1.denominator * r2.denominator);
            return result;
        }
        public static bool operator >(Rational r1, Rational r2)
        {
                return (r1 > r2);
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            return !(r1>r2);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            Rational result = new Rational();
            result.numerator = (r1.numerator * r2.denominator);
            result.denominator = (r1.denominator * r2.numerator);
            return result;
        }

        public static bool  operator ==(Rational r1, Rational r2)
        {
            if (r1.numerator / r1.denominator == r2.numerator / r2.denominator)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1==r2);
        }
        #endregion
        #region Equals and ToString
        public override bool Equals(object obj)
        {
            Rational rational = obj as Rational;
            if (rational.numerator == numerator)
            {
                if (rational.denominator == denominator)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public override string ToString()
        {
            return numerator + "/" + denominator;
        }
        #endregion
    }
}
