using Chat.Core.Entities;
using System.Threading.Tasks;

namespace Chat.Core.Interfaces
{
    public interface IUtilsService
    {
        Task<Stock> GetStockInformation(string stockCode);
    }
}
