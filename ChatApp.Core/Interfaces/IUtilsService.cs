using ChatApp.Core.Entities;
using System.Threading.Tasks;

namespace ChatApp.Core.Interfaces
{
    public interface IUtilsService
    {
        Task<Stock> GetStockInformation(string stockCode);
    }
}
