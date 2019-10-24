using System;
using System.Collections.Generic;
using System.Drawing;

namespace DrawingImages.WithoutUsingFlyweight
{
    class DrawingImagesWithoutUsingFlyWeight
    {
        public DrawingImagesWithoutUsingFlyWeight(Graphics graphics, int totalImages)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Random random = new Random();
            List<MyImage> images1Info = new List<MyImage>();
            for (int i = 0; i < totalImages; i++)
                images1Info.Add(new MyImage(Images.doraemon, new Point(random.Next(900), random.Next(900))));

            List<MyImage> images2Info = new List<MyImage>();
            for (int i = 0; i < totalImages; i++)
                images2Info.Add(new MyImage(Images.nobita, new Point(random.Next(900), random.Next(900))));

            foreach (MyImage image in images1Info)
                image.Draw(graphics);

            foreach (MyImage image in images2Info)
                image.Draw(graphics);
            watch.Stop();
            Console.WriteLine("Without using flyweight: " + watch.ElapsedMilliseconds.ToString());
        }
    }
}
