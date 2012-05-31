using System.Windows;
using TwitShot.Contracts;
using TwitShot.Services;

namespace TwitShot.Presentation
{
    public partial class OAuthPinView : Window
    {
        public IAuthenticationService Auth = new AuthenticationService();

        public OAuthPinView()
        {
            InitializeComponent();
            browser.Source = Auth.GetAuthenticationUri();

        }

        private void PinUpdate_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = DataContext as OAuthPinViewModel;

            if (viewModel == null) return;
            viewModel.OAuth = Auth.OAuth;

            new LoginCommand().Execute(viewModel);
        }
    }
}
