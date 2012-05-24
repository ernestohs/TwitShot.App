using System;
using RestSharp;
using TwitShot.Contracts;

namespace TwitShot.API
{
    /// <summary>
    /// Based upon http://dev.twitpic.com/docs/
    /// </summary>
    public class TwitPicAPI : ITwitPicAPI
    {
        public IRestClient Client;
        public IRestRequest Request;
        public IOAuth OAuth;
        
        private const string BaseUrl = "http://api.twitpic.com";
        private const string HeaderTemplate =
            @"X-Verify-Credentials-Authorization: OAuth realm=""http://api.twitter.com/"", oauth_consumer_key=""{0}"", oauth_signature_method=""HMAC-SHA1"", oauth_token=""{1}"", oauth_timestamp=""{2}"", oauth_nonce=""{3}"", oauth_version=""1.0"", oauth_signature=""{4}""";

        private string _authString;
        protected string Authorization
        {
            get
            {
                if (string.IsNullOrEmpty(_authString))
                {
                    _authString = string.Format(HeaderTemplate, OAuth.ConsumerKey, OAuth.Token, OAuth.TimeStamp,
                                                OAuth.Nonce, OAuth.Signature);
                }
                return _authString;
            }
        }

        private T Execute<T>(IRestRequest request) where T : new()
        {
            Client.BaseUrl = BaseUrl;
            request.AddHeader("X-Verify-Credentials-Authorization", Authorization);

            var response = Client.Execute<T>(request);
            return response.Data;
        }

        public void Login(string userName, string password, Action<IStatus> action)
        {
            throw new NotImplementedException();
        }

        public TwitPicResponse Upload(string path, string message)
        {
            Request = new RestRequest();
            Request.AddParameter("key", Properties.Settings.Default.APIKey);
            Request.AddFile("media", path);
            return Execute<TwitPicResponse>(Request);
        }

        public object GetTumbnail(int imageId, ThumbSize size)
        {
            throw new NotImplementedException();
        }

    }
}
