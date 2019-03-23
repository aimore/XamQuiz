using System;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;
using XamQuiz.Model;

namespace XamQuiz.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public static bool isTimerRunning;
        Pages.UserProfilePage userProfilePage;
        public LoginPageViewModel()
        {
            UserAvatar = Resource.Constants.AvatarEndpoint + "abott" + ".png";
            isTimerRunning = true;
            Random random = new Random();
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
             {
                // Do something
                UserAvatar = $"{Resource.Constants.AvatarEndpoint}{random.Next(1, 100).ToString()}.png";
                return isTimerRunning; // True = Repeat again, False = Stop the timer
            });

            if (userProfilePage == null)
                userProfilePage = new Pages.UserProfilePage();
        }

        public ICommand LoginCommand => Cmd() ?? RegCmd(async () =>
        {
            isTimerRunning = false;
            await Application.Current.MainPage.Navigation.PushAsync(userProfilePage, true);
            //throw new Exception(); // shouldSuppressExceptions = true, will be no crash

        }, TimeSpan.FromMilliseconds(300), true, ex => {
            //handle exception if you want
        });

        public string _userAvatar;
        public string UserAvatar
        {
            get => Get(_userAvatar);
            set => Set(value);
        }
    }
}
