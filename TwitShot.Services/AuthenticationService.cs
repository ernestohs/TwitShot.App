using System;
using System.Collections.Generic;
using TwitShot.API;
using TwitShot.Contracts;

namespace TwitShot.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        protected bool _isSignedOn;
        public bool IsSignedOn { get { return _isSignedOn; } }
        //[Inject]
        public IOAuth OAuth { get; set; }

        private readonly ICollection<ICredentials> _accounts = new List<ICredentials>();
        private readonly TwitterHelper _twitterHelper = new TwitterHelper();

        public ICollection<ICredentials> Accounts { get { return _accounts; } }

        public void Login(ICredentials credentials, Action<IStatus> onCompleteCallback)
        {
            if (credentials.Service.OAuth == null)
            {
                credentials.Service
                    .Login(
                        credentials.UserName,
                        credentials.Password,
                        status =>
                        {
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
            else
            {
                var status = new Status {Success = credentials.Service.OAuth.IsValid};
                
                onCompleteCallback(status);
            }
        }

        public Uri GetAuthenticationUri()
        {
            var uri = new Uri(_twitterHelper.AuthorizationLinkGet());

            if (OAuth == null) { OAuth = new OAuthObject(); }

            OAuth.TimeStamp = _twitterHelper.GenerateTimeStamp();
            OAuth.Nonce = _twitterHelper.GenerateNonce();
            OAuth.ConsumerKey = _twitterHelper.TokenSecret;
            OAuth.Token = _twitterHelper.Token;
            return uri;
        }
    }
}
