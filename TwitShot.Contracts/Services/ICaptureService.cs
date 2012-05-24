namespace TwitShot.Contracts
{
    public interface ICaptureService
    {
        object Capture(double x, double y, double width, double height);
    }
}
