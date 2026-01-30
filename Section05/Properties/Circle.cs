namespace Section05.Properties
{
    public class Circle
    {
        private const double pi = 3.14159; // constant (same for all instances)
        private readonly int rad; // read only variable (depend on each instance)

        public Circle(int r)
        {
            rad = r;
        }

        public double GetArea()
        {
            return pi * (rad ^ 2);
        }

        public double GetPerimeter()
        {
            return 2 * pi * rad;
        }
    }
}