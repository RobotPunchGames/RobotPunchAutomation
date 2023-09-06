using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RobotPunchAutomation.Resources.Helpers;

namespace RobotPunchAutomation.Tests
{
    [TestFixture]
    public class SmokeTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Close();
        }

        [Test]
        public void BasicSmokeTest()
        {
            _driver.Navigate().GoToUrl("https://youtube.com");
        }

        [Test]
        public async Task ApiSmokeTest()
        {
            //Make API Call
            await ApiRequestFactory.SendRequest(ApiEndpoint.CoinGecko._coinGeickoHealthCheck);
        }
    }
}