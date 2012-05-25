using System.Windows.Input;
using TwitShot.Presentation.Commands;
using System.ComponentModel.Composition;

namespace TwitShot.Presentation {

    [Export(typeof(IShell))]
    public class ShellViewModel : IShell
    {
        public ICommand ExitCommand { get; set; }
        public ICommand AreaCaptureCommand { get; set; }

        public ShellViewModel()
        {
            ExitCommand = new AppExitCommand();
            AreaCaptureCommand = new AreaCaptureCommand();
            new SignInCommand().Execute(this);
        }
    }
}
