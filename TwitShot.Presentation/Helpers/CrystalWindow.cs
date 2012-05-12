using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TwitShot.Presentation
{
    public sealed class CrystalWindow : Window
    {
        private Point _lastPoint;

        public CrystalWindow() : base()
        {
            Background = Brushes.Transparent;
            WindowStyle = WindowStyle.None;
            var border = new Border
                             {
                                 Name = "canvasBackground",
                                 HorizontalAlignment = HorizontalAlignment.Stretch,
                                 VerticalAlignment = VerticalAlignment.Stretch,
                                 Margin = new Thickness(5, 0, 5, 5)
                             };

            // Background="#0E9DEBF5"
            AddChild(border);
        }
    }
}