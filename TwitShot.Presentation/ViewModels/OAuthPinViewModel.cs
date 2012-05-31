using System;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using TwitShot.Contracts;

namespace TwitShot.Presentation
{
    [Export(typeof(OAuthPinViewModel))]
    public class OAuthPinViewModel : PropertyChangedBase, IViewAware
    {
        private Window dialogWindow;

        public event EventHandler<ViewAttachedEventArgs> ViewAttached;

        private IStatus _authStatus { get; set; }
        public IStatus AuthStatus 
        { 
            get { return _authStatus; } 

            set
            {
                _authStatus = value;
                if (_authStatus != null && _authStatus.Success)
                {
                    var root = IoC.Get<IShell>() as ShellViewModel;
                    if (root != null) root.SysTrayVisible = Visibility.Visible;
                    CloseWindow();
                }

                NotifyOfPropertyChange(() => AuthStatus);
            } 
        }

        private string _pin { get; set; }
        public string PIN { get { return _pin; } set { _pin = value; NotifyOfPropertyChange(() => PIN); } }

        private IOAuth _OAuth { get; set; }
        public IOAuth OAuth { get { return _OAuth; } set { _OAuth = value; NotifyOfPropertyChange(() => OAuth); } }


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