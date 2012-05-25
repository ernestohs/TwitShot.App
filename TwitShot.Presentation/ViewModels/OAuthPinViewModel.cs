using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace TwitShot.Presentation
{
    [Export(typeof(OAuthPinViewModel))]
    public class OAuthPinViewModel : PropertyChangedBase
    {
        private string _pin { get; set; }
        public string PIN { get { return _pin; } set { _pin = value; NotifyOfPropertyChange(() => PIN); } }
    }
}