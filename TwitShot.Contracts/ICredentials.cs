namespace TwitShot.Contracts
{
    public interface ICredentials
    {
        IPublishService Service { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }
}