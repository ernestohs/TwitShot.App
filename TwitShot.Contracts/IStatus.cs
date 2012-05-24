namespace TwitShot.Contracts
{
    public interface IStatus
    {
        bool Success { get; set; }
        string Message { get; set; }
        object Value { get; set; }
    }
}
