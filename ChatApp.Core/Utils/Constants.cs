namespace Chat.Core.Utils
{
    public static class Constants
    {
        public const string COMMAND_STOCK = "/stock=";
        public const string STOCK_API_URL = "https://stooq.com/q/l/?f=sd2t2ohlcv&h&e=csv&s=";
        public const string STOCK_API_ERROR_CODE = "STOCK_ERROR_CODE";
        public const string STOCK_API_ERROR_CODE_MESSAGE = "An error occurred when retrieving the stock information";
    }
}