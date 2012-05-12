using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Caliburn.Micro;

namespace TwitShot.Presentation
{
    public class AreaCaptureCommand : ICommand
    {
        //[Inject]
        //public IAuthenticationService AuthenticationService;

        public void Execute(object parameter)
        {
            var windowManager = new CustomWindowManager();
            var settings = new Dictionary<string, object>
                                 {
                                     { "WindowStyle", WindowStyle.None},
                                     { "ShowInTaskbar", false},
                                     { "AllowsTransparency", true},
                                     { "Background", new SolidColorBrush(Colors.Transparent)},
                                     { "StartupLocation", WindowStartupLocation.CenterScreen},

                                 };

            windowManager.ShowWindow(IoC.Get<ClipperViewModel>(), null, settings);
        }

        public bool CanExecute(object parameter)
        {
            return true; // AuthenticationService.IsSignedOn;
        }

        public event EventHandler CanExecuteChanged;
    }
}