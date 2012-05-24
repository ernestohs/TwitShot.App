using System.ComponentModel.Composition;
using System.Windows.Media;
using Caliburn.Micro;
using TwitShot.Contracts;

namespace TwitShot.Presentation
{
    [Export(typeof(ComposeViewModel))]
    public class ComposeViewModel : PropertyChangedBase
    {
        private ImageSource _image;
        private string _message;

        public string Message { get { return _message; } set { _message = value; NotifyOfPropertyChange(() => Message); } }
        public ImageSource Image { get { return _image; } set { _image = value; NotifyOfPropertyChange(() => Image); } }
        
        public ComposeViewModel()
        {
            Message = "#TwitShot ";
        }

        public void RequestComplete(IStatus obj)
        {
            if (obj == null) return;

            if (obj.Success)
            {
                //obj.Value // Message on success
                // close this window
            }
            else
            {
                //obj.Message; // Error message
            }
        }
    }
}
