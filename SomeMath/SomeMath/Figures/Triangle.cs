using System;

namespace SomeMath.Figures
{
    public class Triangle : IFigures
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if ((a <= 0 || b <= 0 || c <= 0) && (a + b < c || b + c < a || a + c < b))
            {
                throw new ArgumentException("There is no triangle with these parameters");
            }

            A = a;
            B = b;
            C = c;
        }

        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            
            return Math.Pow(p * (p - A) * (p - B) * (p - C), 0.5);
        }

        public bool IsTriangleRectangle()
        {

            if (A > B && A > C)
            {
                return B * B + C * C - A * A == 0;
            }
            else if (B > A && B > C)
            {
                return A * A + C * C - B * B == 0;
            }
            else
            {
                return A * A + B * B - C * C == 0;
            }
        }
    }
}
