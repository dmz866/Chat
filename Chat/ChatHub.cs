using Chat.Core.Utils;
using Microsoft.AspNet.SignalR;
using Chat.Core.Interfaces;
using Chat.Infrastructure.Services;
using Chat.Core.Entities;
using System.Threading.Tasks;
using System;

namespace Chat
{
    public class ChatHub : Hub
    {
        private readonly IUtilsService _utilsService;
        private readonly IPostService _postService;
        public ChatHub()
        {
            _utilsService = new UtilsService();
            _postService = new PostService();
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
            else
            {
                await createPost(userName, message);
            }

            Clients.All.addNewMessageToPage(userName, message);            
        }

        private async Task createPost(string userName, string message)
        {
            Post post = new Post();
            post.Message = message;
            post.UserName = userName;
            post.CreatedAt = DateTime.Now;

            await _postService.Create(post);
        }
    }
}