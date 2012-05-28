using System.Windows;
using Caliburn.Micro;

namespace TwitShot.Presentation
{
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            UserName.Focus();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LockCredentials();
            new LoginCommand().Execute(DataContext);
        }

        private void LockCredentials()
        {
            loadingIndicator.Visibility = Visibility.Visible;
            UserName.Opacity = Password.Opacity = 0.5;
            UserName.IsEnabled = Password.IsEnabled = false;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            var viewModel = IoC.Get<IShell>() as ShellViewModel;
            if (viewModel != null)
            {
                viewModel.SysTrayVisible = Visibility.Visible; //TODO: Add converter and change to bool
            }
            
            base.OnClosing(e);
        }
    }
}
