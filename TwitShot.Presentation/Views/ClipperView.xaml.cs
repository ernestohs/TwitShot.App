using System;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TwitShot.Presentation
{
    public partial class ClipperView : Window
    {
        private Point _lastPoint;
        
        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            Dimentions.Text = String.Format("{0} px x {1} px", Height, Width);
        }

        private void OnMouseDown(object sender, EventArgs e)
        {
            var args = e as MouseEventArgs;
            if (args == null) return;

            if (args.LeftButton == MouseButtonState.Pressed &&
            args.MouseDevice.DirectlyOver == imageBackground)
            {
                _lastPoint = args.GetPosition(this);
            }
        }

        private void OnMouseMove(object sender, EventArgs e)
        {
            var args = e as MouseEventArgs;
            if (args == null) return;

            if (args.LeftButton == MouseButtonState.Pressed &&
                args.MouseDevice.DirectlyOver == imageBackground)
            {
                if (_lastPoint.X >= 0 && _lastPoint.Y >= 0)
                {
                    var topPosition = args.GetPosition(this).Y;
                    topPosition -= _lastPoint.Y;
                    var leftPosition = args.GetPosition(this).X;
                    leftPosition -= _lastPoint.X;
                    Top += topPosition;
                    Left += leftPosition;
                }
            }
        }

        private void OnMouseDoubleClick(object sender, EventArgs e)
        {
            var viewModel = DataContext as ClipperViewModel;
            if (viewModel == null) return;

            Hide();
            viewModel.CaptureArea(Left, Top, ActualWidth, ActualHeight);
            Close();
        }

        private void OnKeyup(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }

        private void TopDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight)
            {
                Height -= e.VerticalChange;
                Top += e.VerticalChange;
            }
            else
            {
                Height = MinHeight + 4;
                TopThumb.ReleaseMouseCapture();
            }
        }

        private void BottomDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight)
            {
                Height += e.VerticalChange;
            }
            else
            {
                Height = MinHeight + 4;
                BottomThumb.ReleaseMouseCapture();
            }
        }

        private void RigthDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Width > MinWidth)
            {
                Width += e.HorizontalChange;
            }
            else
            {
                Width = MinWidth + 4;
                RigthThumb.ReleaseMouseCapture();
            }
        }

        private void LeftDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Width > MinWidth)
            {
                Width -= e.HorizontalChange;
                Left += e.HorizontalChange;
            }
            else
            {
                Width = MinWidth + 4;
                LeftThumb.ReleaseMouseCapture();
            }
        }

        private void TlDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight && Width > MinWidth)
            {
                Height -= e.VerticalChange;
                Top += e.VerticalChange;

                Width -= e.HorizontalChange;
                Left += e.HorizontalChange;
            }
            else
            {
                Height = MinHeight + 4;
                Width = MinWidth + 4;

                CornerTlThumb.ReleaseMouseCapture();
            }
        }

        private void TrDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight && Width > MinWidth)
            {
                Height -= e.VerticalChange;
                Width += e.HorizontalChange;

                Top += e.VerticalChange;
            }
            else
            {
                Height = MinHeight + 4;
                Width = MinWidth + 4;

                CornerTrThumb.ReleaseMouseCapture();
            }
        }

        private void BlDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight && Width > MinWidth)
            {
                Height += e.VerticalChange;
                Width -= e.HorizontalChange;
                Left += e.HorizontalChange;
            }
            else
            {
                Height = MinHeight + 4;
                Width = MinWidth + 4;

                CornerBlThumb.ReleaseMouseCapture();
            }
        }

        private void BrDragDelta(object sender, DragDeltaEventArgs e)
        {
            if (Height > MinHeight && Width > MinWidth)
            {
                Height += e.VerticalChange;
                Width += e.HorizontalChange;
            }
            else
            {
                Height = MinHeight + 4;
                Width = MinWidth + 4;
                CornerBrThumb.ReleaseMouseCapture();
            }
        }

        private void DropContent(object sender, DragEventArgs e)
        {
            var viewModel = DataContext as ClipperViewModel;
            if (viewModel == null) return;

            Hide();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                var files = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (files != null)
                {
                    var image = new BitmapImage(new Uri(files[0], UriKind.RelativeOrAbsolute));
                    viewModel.SetImage(image);
                }
            }
            else if (e.Data.GetDataPresent(DataFormats.Text))
            {
                var url = e.Data.GetData(DataFormats.Text) as string;
                var image = new BitmapImage(new Uri(url, UriKind.RelativeOrAbsolute));
                image.DownloadCompleted += (a, b) => viewModel.SetImage(image);
            }
            Close();
        }
    }
}
