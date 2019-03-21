using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamQuiz.Pages
{
    public partial class LoginPage : ContentPage
    {
        Pages.UserProfilePage page;
        public LoginPage()
        {
            InitializeComponent();
            if(page == null)
                page = new Pages.UserProfilePage();
        }
        bool _isBusy;
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (_isBusy)
                return;
            try
            {
                if (page == null)
                    page = new Pages.UserProfilePage();
                _isBusy = true;
                await Navigation.PushModalAsync(page, true);
            }
            catch (Exception ex)
            {
                return;
            }
            _isBusy = false;
        }
    }
}
