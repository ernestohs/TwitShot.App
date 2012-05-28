using System;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using TwitShot.Contracts;
using log4net;
using PixelFormat = System.Drawing.Imaging.PixelFormat;

namespace TwitShot.Interop
{
    public class Screen : IResource
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Screen));

        public object Capture(int x, int y, int width, int height)
        {
            return Capture(new Rectangle(x, y, width, height));
        }

        public object Capture(Point p, Size s)
        {
            return Capture(new Rectangle(p, s));
        }

        public object Capture(Rectangle rectangle)
        {
            var bitmap = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);

            var graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(
                        new Point(rectangle.X, rectangle.Y), 
                        new Point(0, 0), 
                        rectangle.Size, 
                        CopyPixelOperation.SourceCopy);

            return Imaging.CreateBitmapSourceFromHBitmap(
                            bitmap.GetHbitmap(), 
                            IntPtr.Zero, 
                            System.Windows.Int32Rect.Empty, 
                            BitmapSizeOptions.FromWidthAndHeight(rectangle.Width, rectangle.Height));

        }
    }
}