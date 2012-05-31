using TwitShot.Contracts;

namespace TwitShot.Services
{
    public class OAuthObject : IOAuth
    {
        public string ConsummerKey { get; set; } // WTF !!!
        public string Token { get; set; }
        public string TimeStamp { get; set; }
        public string Nonce { get; set; }
        public string Signature { get; set; }
        public string ConsumerKey { get; set; }
        
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(ConsumerKey) && !string.IsNullOrEmpty(Token);
            }
        }
    }
}
