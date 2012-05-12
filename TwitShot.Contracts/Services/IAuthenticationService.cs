namespace TwitShot.Contracts
{
    public interface IAuthenticationService
    {
        IStatus Login(ICredentials credentials);
    }
}