using System;
using System.Windows.Input;
using TwitShot.Contracts;
using TwitShot.Services;

namespace TwitShot.Presentation
{
    public class LoginCommand : ICommand
    {
        //[Inject]
        public IAuthenticationService AuthService;

        public void Execute(object parameter)
        {
            var viewModel = parameter as OAuthPinViewModel;
            if (viewModel == null) return;
            
            var credentials = new Credentials
            {
                Service = new PublishService(viewModel.OAuth)
            };

            AuthService.Login(credentials, status => { viewModel.AuthStatus = status; });
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
