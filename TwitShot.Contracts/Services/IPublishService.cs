using System;

namespace TwitShot.Contracts
{
    public interface IPublishService
    {
        IOAuth OAuth { get; set; }
        void Send(object image, string message, Action<IStatus> callback);
        void Login(string userName, string password, Action<IStatus> action);
    }
}