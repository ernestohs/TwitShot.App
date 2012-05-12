using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace TwitShot.Presentation
{
    public partial class ComposeView : Window
    {

        private void OnLostFocus(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void OnKeyup(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }

        public ComposeView()
        {
            InitializeComponent();
        }

        private void DropContent(object sender, DragEventArgs e)
        {
            var viewModel = DataContext as ComposeViewModel;
            if (viewModel == null) return;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                var files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files != null)
                {
                    var image = new BitmapImage(new Uri(files[0], UriKind.RelativeOrAbsolute));
                    viewModel.Image = image; 
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                loadingIndicator.Visibility = Visibility.Visible;
                var url = e.Data.GetData(DataFormats.Text) as string;
                var image = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                image.DownloadCompleted += (a,b) => { loadingIndicator.Visibility = Visibility.Hidden; };
                viewModel.Image = image;
            }
        }

    }
}
