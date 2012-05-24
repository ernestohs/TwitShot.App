using TwitShot.Contracts;

namespace TwitShot.Services
{
    public class Status : IStatus
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Value { get; set; }
    }
}