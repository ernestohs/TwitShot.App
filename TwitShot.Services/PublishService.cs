using System;
using TwitShot.API;
using TwitShot.Contracts;
using System.Drawing;

namespace TwitShot.Services
{
    public class PublishService : IPublishService
    {
        public TwitPicAPI TwitPic = new TwitPicAPI();

        public void Login(string userName, string password, Action<IStatus> action)
        {
            throw new NotImplementedException();
        }

        public void Send(object image, string message, Action<IStatus> callback)
        {
            var target = image as Image;

            TwitPic.Upload(GenerateTempFile(target), message);
        }

        private string GenerateTempFile(Image target)
        {
            string filename = String.Format(@"C:\TMP\{0}.png", Guid.NewGuid());
            target.Save(filename);
            return filename;
        }
    }
}
