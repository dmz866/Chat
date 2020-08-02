using System;
using System.Threading.Tasks;
using Chat.Core.Entities;
using Chat.Core.Interfaces;
using Chat.Core.Utils;
using Chat.Infrastructure.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChatTest
{
    [TestClass]
    public class UtilsServiceUnitTest
    {
        IUtilsService _utilsService;
        public UtilsServiceUnitTest()
        {
            _utilsService = new UtilsService();
        }
        [TestMethod]
        public async Task TestGetStockInformation()
        {
            string stockCode = "aapl.us";
            Stock result = await _utilsService.GetStockInformation(stockCode);
            Assert.IsTrue(!string.IsNullOrEmpty(result.Symbol) && !result.Symbol.Equals(Constants.STOCK_API_ERROR_CODE));
        }
    }
}
