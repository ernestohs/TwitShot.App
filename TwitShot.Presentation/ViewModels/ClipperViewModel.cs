using System.ComponentModel.Composition;
using System.Windows.Media;
using Caliburn.Micro;
using TwitShot.Contracts;
using TwitShot.Presentation.Commands;
using TwitShot.Services;

namespace TwitShot.Presentation
{
    [Export(typeof(ClipperViewModel))]
    public class ClipperViewModel: Screen
    {
        public ICaptureService CaptureService = new CaptureService();

        public void CaptureArea(double x, double y, double width, double height)
        {
            new ComposeCommand().Execute(CaptureService.CopyArea(x, y, width, height) as ImageSource);
        }
    }
}