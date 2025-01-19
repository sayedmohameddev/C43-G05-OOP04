using System;

namespace C43_G05_OOP04
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }

        public void DisplayDimensions()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.DisplayDimensions(); 

            Rectangle rect2 = new Rectangle(10, 20);
            rect2.DisplayDimensions(); 

            Rectangle rect3 = new Rectangle(15);
            rect3.DisplayDimensions(); 
        }
    }
}
