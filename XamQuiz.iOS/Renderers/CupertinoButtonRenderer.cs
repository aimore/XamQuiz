using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamQuiz.Custom;
using XamQuiz.iOS.Renderers;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(CupertinoButtonRenderer), new[] { typeof(MaterialDesignVisual) })]
namespace XamQuiz.iOS.Renderers
{
    public class CupertinoButtonRenderer : ButtonRenderer
    {
        public CupertinoButtonRenderer()
        {
        }
    }
}
