using TwitShot.Contracts;
using TwitShot.Interop;

namespace TwitShot.Services
{
    public class CaptureService : ICaptureService
    {
        public object CopyArea(double x, double y, double width, double height)
        {
            return Screen.CopyArea((int)x, (int)y, (int)width, (int)height); //TODO: This could be the screen, a webcam, a scanner, etc.
        }
    }
}