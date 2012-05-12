using System;
using System.Windows;
using System.Windows.Input;

namespace TwitShot.Presentation
{
    public class AppExitCommand : ICommand
    {
        public void Execute(object parameter)
        {
            Application.Current.Shutdown();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}