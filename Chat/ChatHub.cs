using Chat.Core.Utils;
using Microsoft.AspNet.SignalR;
using Chat.Core.Interfaces;
using Chat.Infrastructure.Services;
using Chat.Core.Entities;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatHub : Hub
    {
        private readonly IUtilsService _utilsService;
        public ChatHub()
        {
            _utilsService = new UtilsService();
        }
        public async Task SendMessage(string userName, string message)
        {
            if(message.Contains(Constants.COMMAND_STOCK))
            {
                Stock stock = new Stock();
                stock = await _utilsService.GetStockInformation(message);

                if(string.IsNullOrEmpty(stock.Symbol) || stock.Symbol.Equals(Constants.STOCK_API_ERROR_CODE))
                {
                    message = Constants.STOCK_API_ERROR_CODE_MESSAGE;
                }
                else
                {
                    message = string.Format("{0} quote is ${1} per share", stock.Symbol, stock.Open);
                }
            }

            Clients.All.addNewMessageToPage(userName, message);
        }
    }
}