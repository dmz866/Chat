using Chat.Core.Entities;
using Chat.Core.Interfaces;
using Chat.Infrastructure.Data;
using System.Threading.Tasks;

namespace Chat.Infrastructure.Services
{
    public class PostService : IPostService
    {
        private readonly ChatContext _context;
        public PostService()
        {
            _context = new ChatContext();
        }
        public async Task Create(Post post)
        {
            _context.Post.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}
