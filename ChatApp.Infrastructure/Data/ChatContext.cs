using Chat.Core.Entities;
using System.Data.Entity;
namespace Chat.Infrastructure.Data
{
    public class ChatContext : DbContext
    {
        public ChatContext()
        {
        }
        public virtual DbSet<Post> Post { get; set; }
    }
}
        