namespace TwitShot.Contracts
{
    public interface ITwitPicAPI
    {
        TwitPicResponse Upload(string path, string message);
        object GetTumbnail(int imageId, ThumbSize size);
    }
}
