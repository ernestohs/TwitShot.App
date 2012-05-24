using System.Drawing;

namespace TwitShot.Contracts
{
    public interface IResource
    {
        object Capture(int x, int y, int width, int height);
        object Capture(Point p, Size s);
        object Capture(Rectangle rectangle);
    }
}