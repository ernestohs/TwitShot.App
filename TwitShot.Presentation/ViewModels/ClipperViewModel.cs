using System.ComponentModel.Composition;
using System.Windows.Input;
using System.Windows.Media;
using Caliburn.Micro;
using TwitShot.Contracts;
using TwitShot.Presentation.Commands;
using TwitShot.Services;

namespace TwitShot.Presentation
{
    [Export(typeof(ClipperViewModel))]
    public class ClipperViewModel : Screen
    {
        //[Inject]
        public ICaptureService CaptureService = new CaptureService();
        private readonly ICommand _composeCommand = new ComposeCommand();

        public void CaptureArea(double x, double y, double width, double height)
        {
            _composeCommand.Execute(CaptureService.Capture(x, y, width, height) as ImageSource);
        }

        public void SetImage(ImageSource image)
        {
            _composeCommand.Execute(image);
        }
    }
}
