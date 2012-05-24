using System.Collections.Generic;
using System.Linq;
using TwitShot.Contracts;
using TwitShot.Interop;

namespace TwitShot.Services
{
    public class CaptureService : ICaptureService
    {
        private IResource _resource = new Screen();
        public IResource Resource
        {
            get { return _resource; }
            set
            {
                if (value != _resource)
                {
                    _resource = value ?? Resources.First(); 
                }
            }
        }

        public readonly ICollection<IResource> Resources = new List<IResource>();

        public CaptureService(IResource resource = null)
        {
            Resources.Add(_resource);
            Resource = resource;
        }

        public object Capture(double x, double y, double width, double height)
        {
            return Resource.Capture((int)x, (int)y, (int)width, (int)height);
        }
    }
}