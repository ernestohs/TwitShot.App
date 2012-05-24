using System.Windows;

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
    }
}
