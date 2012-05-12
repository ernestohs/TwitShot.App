using System;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using TwitShot.Contracts;
using PixelFormat = System.Drawing.Imaging.PixelFormat;

namespace TwitShot.Interop
{
    public sealed class Screen : IResource
    {
        public static object CopyArea(int x, int y, int width, int height)
        {
            return CopyArea(new Rectangle(x, y, width, height));
        }

        public static object CopyArea(Point p, Size s)
        {
            return CopyArea(new Rectangle(p, s));
        }

        public static object CopyArea(Rectangle rectangle)
        {
            var bitmap = new Bitmap(rectangle.Width, rectangle.Height, PixelFormat.Format32bppArgb);

            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(new Point(rectangle.X, rectangle.Y), new Point(0, 0), rectangle.Size, CopyPixelOperation.SourceCopy);

            return Imaging.CreateBitmapSourceFromHBitmap(bitmap.GetHbitmap(), IntPtr.Zero, System.Windows.Int32Rect.Empty, BitmapSizeOptions.FromWidthAndHeight(rectangle.Width, rectangle.Height));

        }

    }
}