using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamQuiz.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamQuiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            Preferences.Set("bottomsheetHeight", mainDisplayInfo.Height / 4);
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
