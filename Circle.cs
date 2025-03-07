using System;

namespace CreatingExceptions
{
    public class Circle
    {
        private double radius;
        private const double MAX_RADIUS = 20;

        public Circle(double newRadius)
        {
            if (newRadius < 0)
            {
                throw new InvalidRadiusException(newRadius);
            }
            else if (newRadius > MAX_RADIUS)
            {
                throw new InvalidRadiusException(newRadius, MAX_RADIUS);
            }
            radius = newRadius;
        }

        public override string ToString()
        {
            return $"Circle[radius={radius}]";
        }
    }
}
