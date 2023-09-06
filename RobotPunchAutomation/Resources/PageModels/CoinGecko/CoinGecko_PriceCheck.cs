namespace RobotPunchAutomation.Resources.PageModels.CoinGecko
{
    public class CoinGecko_PriceCheck
    {
        public Currency Bitcoin { get; set; }
    
        public class Currency
        {
            public double Usd { get; set; }
        }
    }
}