using System;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using TwitShot.Contracts;

namespace TwitShot.Presentation
{
    [Export(typeof(LoginViewModel))]
    public class LoginViewModel : PropertyChangedBase, IViewAware
    {
        private Window dialogWindow;

        public event EventHandler<ViewAttachedEventArgs> ViewAttached;

        private IStatus _status;
        public IStatus AuthStatus { 
            get { return _status; } 
            set
            {
                if(_status.Success)
                {
                    CloseWindow();
                }
                _status = value;  NotifyOfPropertyChange(() => AuthStatus);
            } 
        }

        private string _userName;
        public string UserName { get { return _userName; } set { _userName = value; NotifyOfPropertyChange(() => UserName); } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; NotifyOfPropertyChange(() => Password); } }

        public void CloseWindow()
        {
            dialogWindow.Close();
        }

        public void AttachView(object view, object context = null)
        {
            dialogWindow = view as Window;
            if (ViewAttached == null) return;

            ViewAttached(this, new ViewAttachedEventArgs { Context = context, View = view });
        }

        public object GetView(object context = null)
        {
            return dialogWindow;
        }
    }
}