using System;

namespace RationalNumbers
{
    public class RationalNumber
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;

            if (denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        public override string ToString()
        {
            return Denominator == 1 ? Numerator.ToString() : $"{Numerator}/{Denominator}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is RationalNumber))
            {
                return false;
            }

            RationalNumber other = (RationalNumber)obj;
            return Numerator == other.Numerator && Denominator == other.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            if (b.Numerator == 0)
                throw new DivideByZeroException("Division by zero.");

            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber a)
        {
            return new RationalNumber(-a.Numerator, a.Denominator);
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator * b.Denominator) < (b.Numerator * a.Denominator);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator * b.Denominator) > (b.Numerator * a.Denominator);
        }

        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator * b.Denominator) <= (b.Numerator * a.Denominator);
        }

        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return (a.Numerator * b.Denominator) >= (b.Numerator * a.Denominator);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
    }
}
