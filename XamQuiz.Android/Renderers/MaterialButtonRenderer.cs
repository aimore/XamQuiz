using System;
using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamQuiz.Droid.Renderers;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(MaterialButtonRenderer), new[] { typeof(XamQuiz.Custom.MaterialDesignVisual) })]
namespace XamQuiz.Droid.Renderers
{
    public class MaterialButtonRenderer : ButtonRenderer
    {
        public MaterialButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            if (e.NewElement != null) 
            {
                    Control.Touch += Control_Touch;
            }
        }

        void Control_Touch(object sender, TouchEventArgs e)
        {
            Control.SetShadowLayer(5, 3, 3, Color.OrangeRed.ToAndroid());
            Control.SetOutlineSpotShadowColor(Color.WhiteSmoke.ToAndroid());
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (disposing)
            {
                if (Control != null)
                {
                    Control.Touch -= Control_Touch;
                }
            }
        }

    }
}
