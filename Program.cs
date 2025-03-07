using System;

namespace CreatingExceptions
{
    class Program
    {
        static void MakeCircle(double radius)
        {
            try
            {
                Circle circle = new Circle(radius);
                Console.WriteLine(circle);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main()
        {
            double[] testValues = { 25, -20, 20, 10, 0 };
            foreach (double value in testValues)
            {
                MakeCircle(value);
            }
        }
    }
}
