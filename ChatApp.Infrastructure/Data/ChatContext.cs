using Microsoft.EntityFrameworkCore;
using Chat.Core.Entities;
namespace Chat.Infrastructure.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext()
        {
        }
        public ChatContext(DbContextOptions<ChatContext> options) : base(options)
        {
        }
        public virtual DbSet<Post> Post { get; set; }
    }
}
        