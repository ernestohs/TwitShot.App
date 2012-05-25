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
            //var viewModel = parameter as LoginViewModel;
            var viewModel = parameter as OAuthPinViewModel;
            if (viewModel == null) return;

            //viewModel.PIN

            //var credentials = new Credentials {
            //                                   UserName = viewModel.UserName,
            //                                   Password = viewModel.Password,
            //                                   Service = new PublishService()
            //                                };

            //AuthService.Login(credentials, status => { viewModel.AuthStatus = status; });
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
