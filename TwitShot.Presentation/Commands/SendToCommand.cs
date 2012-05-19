using System;
using System.Windows.Input;

namespace TwitShot.Presentation.Commands
{
    public class SendToCommand : ICommand
    {

        //[Inject]
        //public IAuthenticationService AuthenticationService;

        //[Inject]
        //public IPublishService PublishService;

        public void Execute(object parameter)
        {
            var model = parameter as ComposeViewModel;
            if (model == null) return;

            //PublishService.Send(model.Image,  model.Message);
        }

        public bool CanExecute(object parameter)
        {
            return true; // AuthenticationService.IsSignedOn;
        }

        public event EventHandler CanExecuteChanged;
    }
}
