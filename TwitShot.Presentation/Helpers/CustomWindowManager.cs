using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Caliburn.Micro;

namespace TwitShot.Presentation
{
    [Export]
    public class CustomWindowManager : WindowManager
    {
        public Window MainWindow(object rootModel, object context = null)
        {
            var settings = new Dictionary<string, object>
                                 {
                                     { "WindowStyle", WindowStyle.None},
                                     { "ShowInTaskbar", false},
                                     { "AllowsTransparency", true},
                                     { "Background", new SolidColorBrush(Colors.Transparent)},
                                 };

            return CreateWindow(rootModel, false, context, settings);
        }
    }
}
