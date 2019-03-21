using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamQuiz.Droid.Renderers;

[assembly: ExportRenderer(typeof(Entry), typeof(MaterialEntryRenderer), new[] { typeof(XamQuiz.Custom.MaterialDesignVisual) })]
namespace XamQuiz.Droid.Renderers
{
    public class MaterialEntryRenderer : EntryRenderer
    {
        public MaterialEntryRenderer(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnFinishInflate()
        {
            base.OnFinishInflate();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (Control == null || sender == null) return;
            GradientDrawable shape = new GradientDrawable();
            shape.SetShape(ShapeType.Rectangle);
            shape.SetCornerRadius(3);
            shape.SetStroke(3, Color.White.ToAndroid());
            if (Build.VERSION.SdkInt < BuildVersionCodes.JellyBean)
                Control.SetBackgroundDrawable(shape);
            else
                Control.SetBackground(shape);
            //this line sets the bordercolor
            //this.Control.SetRawInputType(Android.Text.InputTypes.TextFlagNoSuggestions);
            //Control.SetHintTextColor(Android.Content.Res.ColorStateList.ValueOf(Color.White.ToAndroid()));

            //if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            //    Control.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Color.White.ToAndroid());
            //else
                //Control.Background.SetColorFilter(Color.White.ToAndroid(), Android.Graphics.PorterDuff.Mode.SrcAtop);
        }
    }
}
