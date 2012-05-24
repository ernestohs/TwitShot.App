using System;
using System.Collections.Generic;

namespace TwitShot.Contracts
{
    public interface IAuthenticationService
    {
        ICollection<ICredentials> Accounts { get; }
        void Login(ICredentials credentials, Action<IStatus> onCompleteCallback);
        bool IsSignedOn { get; }
    }
}
