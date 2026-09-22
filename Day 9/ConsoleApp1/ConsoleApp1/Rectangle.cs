namespace Task
{
    public struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width , int height)
        {
            Width = width;
            Height = height;
        }


        public override string ToString()
        {
            return $"Width: {Width} , Height: {Height}";
        }

    }



}
