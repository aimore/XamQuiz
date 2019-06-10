using System;
using System.Collections.Generic;
using XamQuiz.Model;
using static XamQuiz.Model.PublicUserScore;

namespace XamQuiz.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        private static readonly Random random = new Random();

        public UserScore _user;
        public UserScore User
        {
            get => Get(_user);
            set => Set(value);
        }

        public List<PublicUser> _userScores;
        public List<PublicUser> UserScores
        {
            get => Get(_userScores);
            set => Set(value);
        }


        public UserProfileViewModel()
        {
            User = GetUser();
            UserScores = GetUserScores();
        }

        UserScore GetUser()
        {
            var savedUser = Xamarin.Essentials.Preferences.Get("UserName", "Zezin da Paraiba");
            return new UserScore
            {
                Id = new Random().Next(1, 100).ToString(),
                Score = new Random().Next(1, 1000),
                UserName = savedUser,
                Country = @"🇳🇿"
            };
        }

        List<PublicUser> GetUserScores()
        {
            var users = new List<PublicUser>();
            string[] names = { "Aaron", "Abdul", "Abe", "Abel", "Abraham", "Michael", "Jordan", "Adolf", "Zeca", "Pedrin", "Juca", "Marinalva", "Rosinei", "Pablo" };
            string[] lastNames = { "Pereira", "Schutz", "Martin", "Craig", "Satori", "Kuznetsov", "Xing", "Alvarez", "Bonnaro", "Escobar" };
            string[] countries = { @"🇮🇪", @"🇷🇸", @"🇸🇪", @"🇧🇷", @"🇯🇵", @"🇺🇸", @"🇫🇷", @"🇬🇧", @"🇩🇪", @"🇦🇺", @"🇪🇸" };

            foreach (var name in names)
            {
                int randomScore = random.Next(0, 10000);
                string randomUserName = $"{name} {lastNames[random.Next(0, 9)] ?? "tester"}";
                string randomCountry = countries[random.Next(0, 10)];
                users.Add(new PublicUser
                {
                    Score = randomScore,
                    UserName = $" {randomUserName} ",
                    Country = randomCountry
                });
            }

            return users;
        }
    }
}
