using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamQuiz.iOS.Renderers;

[assembly: ExportRenderer(typeof(ContentPage), typeof(BasePageRenderer))]
namespace XamQuiz.iOS.Renderers
{
    public class BasePageRenderer : PageRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            ViewController.NavigationController.InteractivePopGestureRecognizer.Enabled = true;
            ViewController.NavigationController.InteractivePopGestureRecognizer.Delegate = new UIGestureRecognizerDelegate();
        }
    }
}
