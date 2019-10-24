using System.Drawing;

namespace DrawingImages.WithoutUsingFlyweight
{
    class MyImage
    {
        public Image Image { get; set; }
        public Point Position { get; set; }

        public MyImage(Image image, Point position)
        {
            Image = image;
            Position = position;
        }

        public void Draw(Graphics graphics)
        {
            if (graphics == null)
                return;

            graphics.DrawImage(Image, Position.X, Position.Y, 100, 100);
        }
    }
}
