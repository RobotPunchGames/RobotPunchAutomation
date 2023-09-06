using System;
using System.Threading.Tasks;
using RobotPunchAutomation.Resources.Helpers;

namespace RobotPunchAutomation
{
    internal class Program
    {
        public static String _testEndpoint = "https://jsonplaceholder.typicode.com/todos/1";

        public static String _coinGecko_BTC_PriceCheck =
            "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd";

        public static String _coinGeickoHealthCheck = "https://api.coingecko.com/api/v3/ping";
        
        public static async Task Main(string[] args)
        {
            //Make API Call
            await ApiRequestFactory.SendRequest(_coinGeickoHealthCheck);
        }
    }
}