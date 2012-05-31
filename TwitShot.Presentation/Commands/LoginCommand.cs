#define OAuth
using System;
using System.Windows.Input;
using TwitShot.Contracts;
using TwitShot.Services;

namespace TwitShot.Presentation
{
    public class LoginCommand : ICommand
    {
        //[Inject]
        public IAuthenticationService AuthService = new AuthenticationService();

        public void Execute(object parameter)
        {
            #if OAuth
            var viewModel = parameter as OAuthPinViewModel;
            if (viewModel == null) return;

            var credentials = new Credentials
            {
                Service = new PublishService(viewModel.OAuth)
            };

            AuthService.Login(credentials, status => { viewModel.AuthStatus = status; }); 
            #else
            var viewModel = parameter as LoginViewModel;
            if (viewModel == null) return;

            viewModel.AuthStatus = new Status{Success = true};
            #endif
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
