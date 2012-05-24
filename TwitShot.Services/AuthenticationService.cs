﻿using System;
using System.Collections.Generic;
using TwitShot.Contracts;

namespace TwitShot.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        protected bool _isSignedOn;
        public bool IsSignedOn { get { return _isSignedOn; } }

        private readonly ICollection<ICredentials> _accounts = new List<ICredentials>();
        public ICollection<ICredentials> Accounts { get { return _accounts; } }

        public void Login(ICredentials credentials, Action<IStatus> onCompleteCallback)
        {
            credentials.Service
                .Login(
                    credentials.UserName, 
                    credentials.Password, 
                    status => {
                                if (status.Success)
                                {
                                    _isSignedOn = true;
                                    Accounts.Add(credentials);
                                }

                                if (onCompleteCallback == null)
                                    return;

                                onCompleteCallback(status);
                            });
        }
    }
}
