using Chat.Core.Entities;
using Chat.Core.Interfaces;
using Chat.Core.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using FileHelpers;
namespace Chat.Infrastructure.Services
{
    public class UtilsService : IUtilsService
    {
        private HttpClient _client;
        public UtilsService()
        {
            _client = new HttpClient();
        }
        public async Task<Stock> GetStockInformation(string stockCode)
        {
            try
            {
                var response = await _client.GetAsync(Constants.STOCK_API_URL + stockCode.Replace(Constants.COMMAND_STOCK, string.Empty));
                var content = response.Content.ReadAsStringAsync().Result;
                var engine = new FileHelperEngine<Stock>();
                var records = engine.ReadString(content);

            }
            catch (Exception ex)
            {

            }

            return new Stock();
        }
    }
}
