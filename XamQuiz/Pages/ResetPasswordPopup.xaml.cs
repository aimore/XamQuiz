using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamQuiz.Pages
{
    public partial class ResetPasswordPopup : Frame
    {
        public ResetPasswordPopup()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            titleLbl.Text = "Password reseted!";
            await Task.Delay(1000);
            await this.ScaleTo(1.2, 100, Easing.BounceIn);
            await this.ScaleTo(0, 100, Easing.BounceOut);
            titleLbl.Text = "Reset password";

        }
    }
}
