using DrawingImages.UseFlyweight;
using DrawingImages.WithoutUsingFlyweight;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlDrawingArea_Paint(object sender, PaintEventArgs e)
        {
            int totalImages = 100;
            Graphics graphics = e.Graphics;
            DrawingImagesWithUsingFlyWeight drawingImages = new DrawingImagesWithUsingFlyWeight(graphics, totalImages);
            DrawingImagesWithoutUsingFlyWeight drawingImages1 = new DrawingImagesWithoutUsingFlyWeight(graphics, totalImages);
        }
    }
}
