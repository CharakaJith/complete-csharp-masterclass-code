namespace Section05.Operator
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // overload + (+ should add things logically)
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p1.Y, p2.X + p2.Y);
        }
    }
}