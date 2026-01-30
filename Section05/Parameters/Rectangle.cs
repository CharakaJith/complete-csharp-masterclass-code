namespace Section05.Parameters
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area 
        { 
            get { return Width * Height; } 
        }

        public Rectangle(int w, int h)
        {
            Width = w;
            Height = h;
        }

        public int GetArea()
        {
            return Area;
        }
    }
}