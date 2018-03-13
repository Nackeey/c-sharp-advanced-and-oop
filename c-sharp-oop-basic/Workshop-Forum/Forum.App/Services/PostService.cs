using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    public static class PostService
    {
        private static object postViewModel;

        internal static Category GetCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            Category category = forumData.Categories.Find(c => c.Id == categoryId);
            return category;
        }

        public static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(p => p.Id == postId);
            IList<ReplyViewModel> replies = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Find(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        internal static string[] GetAllCategoryNames()
        {
            ForumData forumData = new ForumData();
            var allCategories = forumData.Categories.Select(c => c.Name).ToArray();
            return allCategories;
        }

        public static IEnumerable<Post> GetPostByCategory(int categoryId)
        {
            ForumData forumData = new ForumData();
            var postIds = forumData.Categories.First(c => c.Id == categoryId).PostIds;
            IEnumerable<Post> posts = forumData.Posts.Where(p => postIds.Contains(p.Id));
            return posts;
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            ForumData forumData = new ForumData();
            Post post = forumData.Posts.Find(p => p.Id == postId);
            PostViewModel pvm = new PostViewModel(post);
            return pvm;
        }

        private static Category EnsureCategory(PostViewModel postView, ForumData forumData)
        {
            var categoryName = postView.Category;
            Category category = forumData.Categories.FirstOrDefault(x => x.Name == categoryName);
            if (category == null)
            {
                var categories = forumData.Categories;
                int categoryId = categories.Any() ? categories.LastOrDefault().Id + 1 : 1;
                category = new Category(categoryId, categoryName, new List<int>());
                forumData.Categories.Add(category);
            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var isContentValid = postViewModel.Content.Any();
            var isCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);

            if (!isTitleValid || !isContentValid || !isCategoryValid)
                return false;

            ForumData forumData = new ForumData();
            var category = EnsureCategory(postViewModel, forumData);
            var postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;
            var author= forumData.Users.SingleOrDefault(u => u.Username == postViewModel.Author);
            var content = string.Join("", postViewModel.Content);
            var post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());
            forumData.Posts.Add(post);
            category.PostIds.Add(postId);
            author.PostIds.Add(postId);
            forumData.SaveChanges();
            postViewModel.PostId = postId;

            return true;
        }
    }
}
