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
            Stock stock = new Stock();

            try
            {                
                var response = await _client.GetAsync(Constants.STOCK_API_URL + stockCode.Replace(Constants.COMMAND_STOCK, string.Empty));
                var content = response.Content.ReadAsStringAsync().Result;
                var engine = new FileHelperEngine<Stock>();
                var records = engine.ReadString(content);
                
                if (records != null && records.Length > 0)
                {
                    stock = records[0];
                }

                return stock;
            }
            catch            
            {
                stock.Symbol = Constants.STOCK_API_ERROR_CODE;
                return stock;
            }
        }
    }
}
