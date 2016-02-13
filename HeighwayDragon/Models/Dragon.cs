using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace HeighwayDragon.Models
{
    public class Dragon
    {
        public Dragon(int pointsCapacity)
        {
            Points = new List<DragonPoint>(pointsCapacity);
        }

        public List<DragonPoint> Points { get; set; }

        /// <summary>
        /// Generate bitmap with fractal points
        /// </summary>
        public Bitmap GenerateBMP(int width, int height, Color backgroundColor, Color pointsColor)
        {
            Bitmap bmp = CreateEndFiilBitmap(width, height, backgroundColor);

            double minX = Points.Min(point => point.X);
            double maxX = Points.Max(point => point.X);
            double minY = Points.Min(point => point.Y);
            double maxY = Points.Max(point => point.Y);

            foreach (DragonPoint point in Points)
            {
                int x = point.CalculateXPosition(minX, maxX, width);
                int y = point.CalculateYPosition(minY, maxY, height);

                bmp.SetPixel(x, y, pointsColor);
            }

            return bmp;
        }

        /// <summary>
        /// Create empty bitmap with specific width and height, brush background
        /// </summary>
        private Bitmap CreateEndFiilBitmap(int width, int height, Color backgroundColor)
        {
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                using (SolidBrush brush = new SolidBrush(backgroundColor))
                {
                    gfx.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }

            return bmp;
        }
    }
}
