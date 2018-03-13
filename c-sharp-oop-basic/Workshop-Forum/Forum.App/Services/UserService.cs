using Forum.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static Forum.App.Controllers.SignUpController;
using Forum.Models;

namespace Forum.App.Services
{
    public static class UserService
    {
        internal static User GetUser(int userId)
        {
            ForumData forumData = new ForumData();
            User user = forumData.Users.Find(u => u.Id == userId);
            return user;
        }

        internal static User GetUser(string username)
        {
            ForumData forumData = new ForumData();
            User user = forumData.Users.Find(u => u.Username == username);
            return user;
        }

        public static bool TryLogInUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            ForumData forumData = new ForumData();
            bool userExists = forumData.Users.Any(u => u.Username == username && u.Password == password);

            return userExists;
        }

        public static SignUpStatus TrySignUpUser(string username, string password)
        {
            bool validUsername = !string.IsNullOrEmpty(username) && username.Length > 3;
            bool validPassword = !string.IsNullOrEmpty(password) && password.Length > 3;

            if (!validUsername || !validPassword)
            {
                return SignUpStatus.DetailsError;
            }

            ForumData forumData = new ForumData();
            bool userAlreadyExists = forumData.Users.Any(u => u.Username == username);

            if (!userAlreadyExists)
            {
                int userId = forumData.Users.LastOrDefault()?.Id + 1 ?? 1;
                var postIds = new List<int>();
                User user = new User(userId, username, password, postIds);
                forumData.Users.Add(user);
                forumData.SaveChanges();

                return SignUpStatus.Success;
            }
            return SignUpStatus.UsernameTakenError;
        }
    }
}
