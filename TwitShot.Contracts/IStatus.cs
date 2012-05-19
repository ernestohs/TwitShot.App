namespace TwitShot.Contracts
{
    public interface IStatus
    {
        bool Success { get; set; }
        object Value { get; set; }
    }
}
