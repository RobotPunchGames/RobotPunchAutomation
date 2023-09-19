using System;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RobotPunchAutomation.Resources.Helpers;
using RobotPunchAutomation.Resources.WebElements;

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
            _driver.Manage().Window.Maximize();
            Console.WriteLine("Setup Completed.");
        }

        [TearDown]
        public void Cleanup()
        {
            _driver.Close();
        }

        [Test]
        public void RobotPunch_Website_SmokeTest()
        {
            _driver.Navigate().GoToUrl(TestingURLs.RobotPunch.HomePage);
            Assert.IsNotNull(_driver.FindElement(RobotPunchPOM.HomePage.BackgroundVideo));
            Console.WriteLine("Background video tested. Is not NULL.");
        }

        [Test]
        public async Task ApiSmokeTest()
        {
            //Make API Call
            await ApiRequestFactory.SendRequest(ApiEndpoint.CoinGecko._coinGecko_BTC_PriceCheck);
        }
    }
}