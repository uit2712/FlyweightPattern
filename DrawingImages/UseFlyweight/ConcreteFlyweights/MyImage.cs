using DrawingImages.UseFlyweight.Flyweights;
using System.Drawing;
namespace DrawingImages.UseFlyweight.ConcreteFlyweights
{
    class MyImage : IMyImage
    {
        protected Image _image;

        public Point Position { get; set; }

        public MyImage(Image image)
        {
            _image = image;
        }

        public void Draw(Graphics graphics)
        {
            if (graphics == null)
                return;

            graphics.DrawImage(_image, Position.X, Position.Y, 100, 100);
        }
    }
}
