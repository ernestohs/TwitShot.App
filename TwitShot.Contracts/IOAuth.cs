namespace TwitShot.Contracts
{
    public interface IOAuth
    {
        string ConsummerKey { get; set; }
        string Token { get; set; }
        string TimeStamp { get; set; }
        string Nonce { get; set; }
        string Signature { get; set; }
        string ConsumerKey { get; set; }
    }
}