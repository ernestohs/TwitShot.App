namespace TwitShot.Contracts
{
    public interface ICaptureService
    {
        object CopyArea(double x, double y, double width, double height);
    }
}