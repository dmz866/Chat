using Chat.Core.Entities;
using System.Threading.Tasks;

namespace Chat.Core.Interfaces
{
    public interface IPostService
    {
        Task Create(Post post);
    }
}
