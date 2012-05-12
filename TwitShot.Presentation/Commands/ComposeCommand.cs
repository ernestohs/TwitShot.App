using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Caliburn.Micro;

namespace TwitShot.Presentation.Commands
{
    class ComposeCommand : ICommand
    {
        public void Execute(object parameter)
        {
            var windowManager = new CustomWindowManager();
            var settings = new Dictionary<string, object>
                                 {
                                     { "WindowStyle", WindowStyle.ToolWindow},
                                     { "ShowInTaskbar", true},
                                     { "StartupLocation", WindowStartupLocation.CenterScreen}
                                 };

            var composeViewModel = IoC.Get<ComposeViewModel>();
            composeViewModel.Image = (parameter as ImageSource);
            windowManager.ShowWindow(composeViewModel, null, settings);
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
