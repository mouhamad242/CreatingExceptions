using System;

namespace CreatingExceptions
{
    public class InvalidRadiusException : Exception
    {
        public InvalidRadiusException(double radius)
            : base($"Invalid radius {radius}: must be non-negative")
        {
        }

        public InvalidRadiusException(double radius, double maxRadius)
            : base($"Invalid radius {radius}: must be between 0 and {maxRadius}")
        {
        }
    }
}
