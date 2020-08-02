using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chat.Infrastructure.Services;
using Chat.Core.Interfaces;
using Chat.Core.Entities;
using System.Threading.Tasks;

namespace ChatTest
{
    /// <summary>
    /// Summary description for PostServiceUnitTest
    /// </summary>
    [TestClass]
    public class PostServiceUnitTest
    {
        IPostService _postService;
        public PostServiceUnitTest()
        {
            _postService = new PostService();
        }
        [TestMethod]
        public async Task TestCreatePost()
        {
            Post post = new Post();
            post.CreatedAt = DateTime.Now;
            post.Message = "TEST";
            post.UserName = "TEST USER";
            await _postService.Create(post);

            Assert.IsTrue(true);
        }
    }
}
