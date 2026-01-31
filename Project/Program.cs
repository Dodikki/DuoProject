using Project.Dto;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        private static PostService _postService;

        static async Task Main(string[] args)
        {
            _postService = new PostService();

            var posts = await _postService.GetAllAsync();

            PostService service = new PostService();


            PostDto newPost = new PostDto
            {
                Title = "test Title",
                Content = "test Content"
            };

            PostDto createdPost = await service.PostNewPost(newPost);


            foreach (var post in posts)
            {
                Console.WriteLine($"ID: {post.Id}");
                Console.WriteLine($"Title: {post.Title}");
                Console.WriteLine($"Content: {post.Content}");
            }

        }
    }
}
