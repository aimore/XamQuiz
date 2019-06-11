using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamQuiz.Model;

namespace XamQuiz.Pages
{
    public partial class LoginPage : ContentPage
    {
        ViewModels.LoginPageViewModel vm;

        public LoginPage()
        {
            InitializeComponent();
            if (BindingContext == null)
                BindingContext = vm = new ViewModels.LoginPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
            foreach (var child in container.Children)
                child.Scale = 0;
            popup.Scale = 0;
        }

        bool _isRegistering;

        async void Register(object sender, System.EventArgs e)
        {
            _isRegistering = !_isRegistering;
            btn.Text = _isRegistering ? "Register" : "Login";
            if (_isRegistering)
                // scale in the children for the panel
                foreach (var child in container.Children)
                {
                    await child.ScaleTo(1.2, 100, Easing.CubicIn);
                    await child.ScaleTo(1, 100, Easing.CubicOut);
                }
            else
                //hide
                foreach (var child in container.Children)
                {
                    await child.ScaleTo(1.2, 100, Easing.CubicIn);
                    await child.ScaleTo(0, 100, Easing.CubicOut);
                }
        }

        async void ShowPopup(object sender, System.EventArgs e)
        {
            await popup.ScaleTo(1.2, 100, Easing.BounceOut);
            await popup.ScaleTo(1, 100, Easing.BounceIn);
        }
    }
}
