using System.Windows;
using System.Windows.Input;
using Caliburn.Micro;
using TwitShot.Presentation.Commands;
using System.ComponentModel.Composition;

namespace TwitShot.Presentation {

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public Visibility SysTrayVisible { get { return _sysTrayVisible; } set { _sysTrayVisible = value; NotifyOfPropertyChange(() => SysTrayVisible); } }

        private Visibility _sysTrayVisible = Visibility.Hidden;

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
