using DrawingImages.UseFlyweight.ConcreteFlyweights;
using DrawingImages.UseFlyweight.FlyweightFactories;
using System;
using System.Drawing;

namespace DrawingImages.UseFlyweight
{
    class DrawingImagesWithUsingFlyWeight
    {
        public DrawingImagesWithUsingFlyWeight(Graphics graphics, int totalImages)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            MyImagesFactory imagesFactory = MyImagesFactory.Instance();
            MyImage[] images = new MyImage[]
            {
                new MyImage(imagesFactory.GetImage("doraemon")),
                new MyImage(imagesFactory.GetImage("nobita"))
            };

            Random random = new Random();
            for (int i = 0; i < totalImages; i++)
            {
                foreach(MyImage image in images)
                {
                    image.Position = new Point(random.Next(900), random.Next(900));
                    image.Draw(graphics);
                }
            }
            watch.Stop();
            Console.WriteLine("Use flyweight: " + watch.ElapsedMilliseconds.ToString());
        }
    }
}
