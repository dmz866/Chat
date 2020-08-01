using ChatApp.Core.Entities;
using ChatApp.Core.Interfaces;
using ChatApp.Core.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ChatApp.Infrastructure.Services
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
            }
            catch(Exception ex)
            {

            }

            return new Stock();
        }
    }
}
