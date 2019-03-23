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
    {        ViewModels.LoginPageViewModel vm;
        public LoginPage()
        {
            InitializeComponent();
            if(BindingContext == null)
                BindingContext = vm = new ViewModels.LoginPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
