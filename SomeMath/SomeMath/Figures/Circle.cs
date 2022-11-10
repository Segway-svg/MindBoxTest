using System;

namespace SomeMath.Figures
{
    public class Circle
    {
        public static double Pi = 3.14;
        public double R { get; }

        public Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("There is no circle with these parameters");
            }

            R = r;
        }

        public double CalculateArea()
        {
            return Pi * R * R;
        }
    }
}
