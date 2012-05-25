using System.ComponentModel.Composition;
using Caliburn.Micro;
using TwitShot.Contracts;

namespace TwitShot.Presentation
{
    [Export(typeof(OAuthPinViewModel))]
    public class OAuthPinViewModel : PropertyChangedBase
    {
        private IStatus _authStatus { get; set; }
        public IStatus AuthStatus { get { return _authStatus; } set { _authStatus = value; NotifyOfPropertyChange(() => AuthStatus); } }

        private string _pin { get; set; }
        public string PIN { get { return _pin; } set { _pin = value; NotifyOfPropertyChange(() => PIN); } }

        private IOAuth _OAuth { get; set; }
        public IOAuth OAuth { get { return _OAuth; } set { _OAuth = value; NotifyOfPropertyChange(() => OAuth); } }
    }
}