using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamQuiz.ViewModels;

namespace XamQuiz.Pages
{
    public partial class UserProfilePage : ContentPage
    {
        UserProfileViewModel _vm;

        public UserProfilePage()
        {
            InitializeComponent();
            this.BindingContext = _vm = new UserProfileViewModel();
            BindableLayout.SetItemsSource(rankingList, _vm.UserScores);
        }
    }
}
