using TwitShot.Contracts;

namespace TwitShot.Presentation
{
    public class Credentials : ICredentials
    {
        public IPublishService Service { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}