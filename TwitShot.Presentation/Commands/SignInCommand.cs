using System;
using System.Windows.Input;
using Caliburn.Micro;

namespace TwitShot.Presentation.Commands
{
    public class SignInCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var windowManager = new CustomWindowManager();

            windowManager.ShowWindow(IoC.Get<OAuthPinViewModel>());
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}