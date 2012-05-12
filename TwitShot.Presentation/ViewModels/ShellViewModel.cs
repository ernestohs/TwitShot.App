using System.Windows.Input;

namespace TwitShot.Presentation {
    using System.ComponentModel.Composition;

    [Export(typeof(IShell))]
    public class ShellViewModel : IShell
    {
        public ICommand ExitCommand { get; set; }
        public ICommand AreaCaptureCommand { get; set; }

        public ShellViewModel()
        {
            ExitCommand = new AppExitCommand();
            AreaCaptureCommand = new AreaCaptureCommand();
        }
    }
}
