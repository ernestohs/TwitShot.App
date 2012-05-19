namespace TwitShot.API
{
    public interface IOAuth
    {
        string ConsummerKey { get; set; }
        string Token { get; set; }
        string TimeStamp { get; set; }
        string nonce { get; set; }
        string Signature { get; set; }
        string ConsumerKey { get; set; }
    }
}