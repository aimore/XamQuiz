﻿using System;
using System.Collections.Generic;
using XamQuiz.Model;
using static XamQuiz.Model.PublicUserScore;

namespace XamQuiz.ViewModels
{
    public class UserProfileViewModel : BaseViewModel
    {
        public UserScore User { get; set; }
        private static readonly Random random = new Random();
        public List<PublicUser> UserScores { get; set; }

        public UserProfileViewModel()
        {
            User = GetUser();
            UserScores = GetUserScores();
        }

        UserScore GetUser()
        {
            return new UserScore
            {
                Id = new Random().Next(1, 100).ToString(),
                Score = new Random().Next(1, 1000),
                UserName = "Zezin da Paraiba",
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
