using System;

namespace RobotPunchAutomation.Resources.Helpers
{
    public class ApiEndpoint
    {
        public static String _testEndpoint = "https://jsonplaceholder.typicode.com/todos/1";
        public class CoinGecko
        {
            public static String _coinGecko_BTC_PriceCheck =
                "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd";

            public static String _coinGeickoHealthCheck = "https://api.coingecko.com/api/v3/ping";
        }
        
        
    }
}